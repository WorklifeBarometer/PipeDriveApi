using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace PipeDriveApi.EntityServices
{
    public class OrganizationRelationshipEntityService<T> : EntityServiceBase
        where T : OrganizationRelationship
    {
        private readonly string _resource;

        public OrganizationRelationshipEntityService(IPipeDriveClient client) : base(client)
        {
            _resource = "organizationRelationships";
        }

        public async Task<ListResult<T>> GetForOrganizationAsync(
            int organizationid, int start = 0, int limit = 100, Sort sort = null)
        {
            var request = new RestRequest(_resource, Method.GET);
            return await GetForOrganizationAsync(request, organizationid, start, limit, sort);
        }

        public async Task<ListResult<T>> GetForOrganizationAsync(
            IRestRequest request, int organizationid, int start = 0, int limit = 100, Sort sort = null)
        {
            request.SetQueryParameter("org_id", organizationid.ToString());
            request.SetQueryParameter("start", start.ToString());
            request.SetQueryParameter("limit", limit.ToString());
            if (sort != null)
                request.SetQueryParameter("sort", sort.ToString());

            var response = await _client.ExecuteRequestWithCustomResponseAsync<
                PaginatedPipeDriveResponse<T>, 
                List<T>>(request);

            return new ListResult<T>(response.Data, response.AdditionalData.Pagination);
        }

        public async Task<IReadOnlyList<T>> GetAllForOrganizationAsync(
            int organizationid, Sort sort = null)
        {
            var request = new RestRequest(_resource, Method.GET);
            return await GetAllForOrganizationAsync(request, organizationid, sort);
        }

        public async Task<IReadOnlyList<T>> GetAllForOrganizationAsync(
            IRestRequest request, int organizationid, Sort sort = null)
        {
            var combinedList = new List<T>();
            int start = 0;
            const int limit = 1000;
            while (true)
            {
                var response = await GetForOrganizationAsync(request, organizationid, start, limit, sort);
                combinedList.AddRange(response);
                start = response.Pagination.NextStart;
                //TODO: API bug - MoreItemsInCollection is true even if there are no additional items
                //if (!response.Pagination.MoreItemsInCollection)
                break;
            }
            return combinedList;
        }
    }
}
