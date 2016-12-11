using PipeDriveApi.EntityServices;
using PipeDriveApi.Serializer;
using RateLimiter;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class PipeDriveClient : PipeDriveClient<Person, Organization, Deal, Product>
    {
        public PipeDriveClient(string apiKey) : base(apiKey)
        {
        }
    }


    public class PipeDriveClient<TPerson, TOrganization, TDeal, TProduct> : IPipeDriveClient
        where TPerson : Person
        where TOrganization : Organization
        where TDeal : Deal
        where TProduct : Product
    {
        private readonly RestClient _Client;
        private readonly string _ApiToken;
        private readonly TimeLimiter _TimeContraint;

        public PipeDriveClient(string apiToken)
        {
            _Client = new RestClient("https://api.pipedrive.com/v1");
            _Client.AddHandler("application/json", PipeDriveJsonSerializer.Default);
            _Client.AddHandler("text/json", PipeDriveJsonSerializer.Default);
            _Client.AddHandler("text/x-json", PipeDriveJsonSerializer.Default);
            _Client.AddHandler("text/javascript", PipeDriveJsonSerializer.Default);
            _Client.AddHandler("*+json", PipeDriveJsonSerializer.Default);

            _ApiToken = apiToken;

            // Fly under the radar by doing only 99 requests per 10 seconds
            _TimeContraint = TimeLimiter.GetFromMaxCountByInterval(99, TimeSpan.FromSeconds(10));

            Persons = new PersonEntityService<TPerson>(this);
            Organizations = new OrganizationEntityService<TOrganization>(this);
            Deals = new DealEntityService<TDeal>(this);
            Products = new ProductEntityService<TProduct>(this);
            Activities = new ActivityEntityService(this);
        }

        public async Task ExecuteRequestAsync(IRestRequest request)
        {
            await _TimeContraint.Perform(async () =>
            {
                request.JsonSerializer = PipeDriveJsonSerializer.Default;
                request.SetQueryParameter("api_token", _ApiToken);

                Debug.WriteLine($"{DateTime.UtcNow:s} {request.Method} {request.Resource}");
                var response = await _Client.ExecuteTaskAsync(request);
                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw response.ErrorException;
                }
            });
        }
        public async Task<T> ExecuteRequestAsync<T>(IRestRequest request) where T : new()
        {
            var response = await ExecuteRequestWithCustomResponseAsync<PipeDriveResponse<T>, T>(request);
            return response.Data;
        }
        public async Task<TResponse> ExecuteRequestWithCustomResponseAsync<TResponse, T>(IRestRequest request)
            where TResponse : PipeDriveResponse<T>, new()
        {
            return await _TimeContraint.Perform(async () =>
            {
                request.JsonSerializer = PipeDriveJsonSerializer.Default;
                request.SetQueryParameter("api_token", _ApiToken);

                Debug.WriteLine($"{DateTime.UtcNow:s} {request.Method} {request.Resource}");
                var response = await _Client.ExecuteTaskAsync<TResponse>(request);
                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    if (response.Data.Success)
                        return response.Data;
                    else
                        throw new PipeDriveException((response.Data).Error);
                }
                else
                {
                    throw response.ErrorException;
                }
            });
        }


        public PersonEntityService<TPerson> Persons { get; private set; }
        public OrganizationEntityService<TOrganization> Organizations { get; private set; }
        public DealEntityService<TDeal> Deals { get; private set; }
        public ProductEntityService<TProduct> Products { get; private set; }
        public ActivityEntityService Activities { get; private set; }

    }
}
