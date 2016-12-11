using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi.EntityServices
{
    public class PersonEntityService<TPerson> : PagingEntityService<TPerson>
        where TPerson : Person
    {
        public PersonEntityService(IPipeDriveClient client) : base(client, "persons")
        {
        }
    }
}
