using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace PipeDriveApi.EntityServices
{
    public abstract class EntityService<TEntity> : EntityServiceBase
        where TEntity : BaseEntity
    {
        protected string Resource;

        protected EntityService(IPipeDriveClient client, string resource) : base(client)
        {
            Resource = resource;
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        {
            var request = new RestRequest(Resource, Method.GET);
            return await GetAllAsync(request);
        }

        protected async Task<IReadOnlyList<TEntity>> GetAllAsync(IRestRequest request)
        {
            var response = await _client.ExecuteRequestAsync<List<TEntity>>(request);
            return response;
        }
    }
}
