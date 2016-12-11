using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi.EntityServices
{
    public class ActivityEntityService : PagingEntityService<Activity>
    {
        public ActivityEntityService(IPipeDriveClient client) : base(client, "activities")
        {
        }

        public async Task<IReadOnlyCollection<Activity>> GetAllByType(string activityType, int? userId = 0)
        {
            var request = new RestRequest("activities?user_id={userId}&type={type}", Method.GET);
            request.AddUrlSegment("userId", userId.GetValueOrDefault().ToString());
            request.AddUrlSegment("type", activityType);

            return await GetAllAsync(request);
        }
    }
}
