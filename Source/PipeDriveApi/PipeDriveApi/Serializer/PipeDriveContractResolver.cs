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
