using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi.EntityServices
{
    public class OrganizationEntityService<TOrganization> : PagingEntityService<TOrganization>
        where TOrganization : Organization
    {
        public OrganizationEntityService(IPipeDriveClient client) : base(client, "organizations")
        {
        }
    }
}
