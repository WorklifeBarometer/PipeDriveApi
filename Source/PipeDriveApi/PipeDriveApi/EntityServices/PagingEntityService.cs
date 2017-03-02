using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeDriveApi;

namespace PipeDriveApi.EntityServices
{
    public abstract class PagingEntityService<TEntity> : EntityServiceBase
        where TEntity : BaseEntity
    {
        protected string _Resource;
        public PagingEntityService(IPipeDriveClient client, string resource) : base(client)
        {
            _Resource = resource;
        }
        public async Task<ListResult<TEntity>> GetAsync(int start = 0, int limit = 100, Sort sort = null)
        {
            var request = new RestRequest(_Resource, Method.GET);
            return await GetAsync(request, start, limit, sort);
        }
        public async Task<ListResult<TEntity>> GetAsync(IRestRequest request, int start = 0, int limit = 100, Sort sort = null)
        {
            request.SetQueryParameter("start", start.ToString());
            request.SetQueryParameter("limit", limit.ToString());
            if (sort != null)
                request.SetQueryParameter("sort", sort.ToString());

            var response = await _client.ExecuteRequestWithCustomResponseAsync<PaginatedPipeDriveResponse<TEntity>, List<TEntity>>(request);
            return new ListResult<TEntity>(response.Data, response.AdditionalData.Pagination);
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync(Sort sort = null)
        {
            var request = new RestRequest(_Resource, Method.GET);
            return await GetAllAsync(request, sort);
        }
        public async Task<IReadOnlyList<TEntity>> GetAllAsync(IRestRequest request, Sort sort = null)
        {
            var combinedList = new List<TEntity>();
            int start = 0, limit = 1000;
            while (true)
            {
                var response = await GetAsync(request, start, limit, sort);
                combinedList.AddRange(response);
                start = response.Pagination.NextStart;
                if(!response.Pagination.MoreItemsInCollection) break;
            }
            return combinedList;
        }
    }
}
