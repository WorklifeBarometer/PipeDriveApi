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
    public static class RestRequestExtensions
    {
        public static void SetQueryParameter(this IRestRequest request, string name, string value)
        {
            var p = request.Parameters.FirstOrDefault(_ => _.Name == name);
            if (p != null)
                p.Value = value;
            else
                request.AddQueryParameter(name, value);
        }
    }
}
