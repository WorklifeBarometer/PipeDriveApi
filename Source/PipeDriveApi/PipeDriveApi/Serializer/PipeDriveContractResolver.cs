using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection;

namespace PipeDriveApi.Serializer
{
    public class PipeDriveContractResolver : DefaultContractResolver
    {
        public PipeDriveContractResolver()
        {
            NamingStrategy = new SnakeCaseNamingStrategy();
        }

        protected override JsonContract CreateContract(Type objectType)
        {
            var contract = base.CreateContract (objectType);
            if (objectType == typeof(DateTime) || objectType == typeof(DateTime?))
                contract.Converter = new ZerosIsoDateTimeConverter("yyyy-MM-dd HH:mm:ss", "0000-00-00 00:00:00");
            return contract;
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);
            var cfa = member.GetCustomAttribute<CustomFieldAttribute>(true);
            if(cfa != null)
            {
                prop.PropertyName = cfa.FieldApiKey;
            }
            return prop;
        }
    }
}
