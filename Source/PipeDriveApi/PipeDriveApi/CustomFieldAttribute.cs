using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class CustomFieldAttribute : Attribute
    {
        readonly string _fieldApiKey;

        public CustomFieldAttribute(string fieldApiKey)
        {
            _fieldApiKey = fieldApiKey;
        }

        public string FieldApiKey => _fieldApiKey;
    }
}
