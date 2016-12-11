using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi.EntityServices
{
    public abstract class EntityServiceBase
    {
        protected readonly IPipeDriveClient _client;

        public EntityServiceBase(IPipeDriveClient client)
        {
            _client = client;
        }
    }
}
