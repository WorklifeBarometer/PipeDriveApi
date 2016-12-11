using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi.EntityServices
{
    public class ProductEntityService<TProduct> : PagingEntityService<TProduct>
        where TProduct : Product
    {
        public ProductEntityService(IPipeDriveClient client) : base(client, "products")
        {
        }
    }
}
