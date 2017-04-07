using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PipeDriveApi.EntityServices
{
    public class ActivityEntityService<TActivity> : PagingEntityService<TActivity>
        where TActivity : Activity
    {
        public ActivityEntityService(IPipeDriveClient client) : base(client, "activities")
        {
        }

        public async Task<IReadOnlyCollection<TActivity>> GetAllByType(string activityType, int? userId = 0)
        {
            var request = new RestRequest("activities?user_id={userId}&type={type}", Method.GET);
            request.AddUrlSegment("userId", userId.GetValueOrDefault().ToString());
            request.AddUrlSegment("type", activityType);

            return await GetAllAsync(request);
        }

        public override async Task<ListResult<TActivity>> GetAsync(int start = 0, int limit = 100, Sort sort = null)
        {
            var request = new RestRequest(_Resource, Method.GET);
            request.SetQueryParameter("user_id", "0"); // all users
            return await GetAsync(request, start, limit, sort);
        }

        public override async Task<IReadOnlyList<TActivity>> GetAllAsync(Sort sort = null)
        {
            var request = new RestRequest(_Resource, Method.GET);
            request.SetQueryParameter("user_id", "0"); // all users
            return await GetAllAsync(request, sort);
        }
    }
}
