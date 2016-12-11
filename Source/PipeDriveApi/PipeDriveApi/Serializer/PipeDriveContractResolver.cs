using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;

namespace PipeDriveApi.Serializer
{
    public class PipeDriveContractResolver : DefaultContractResolver
    {
        public PipeDriveContractResolver() : base()
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

        protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
        {
            var cfa = member.GetCustomAttribute<CustomFieldAttribute>(true);
            if (cfa != null)
            {
                return new PipeDriveValueProvider(member, cfa.FieldApiKey);
            }
            return base.CreateMemberValueProvider(member);
        }
    }

    public class PipeDriveValueProvider : IValueProvider
    {
        private readonly MemberInfo _memberInfo;
        private readonly string _fieldApiKey;

        public PipeDriveValueProvider(MemberInfo memberInfo, string fieldApiKey)
        {
            _memberInfo = memberInfo;
            _fieldApiKey = fieldApiKey;
        }

        public void SetValue(object target, object value)
        {
            target.GetType().GetProperty(_memberInfo.Name).SetValue(target, value);
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="target">The target to get the value from.</param>
        /// <returns>The value.</returns>
        public object GetValue(object target)
        {
            return target;
        }
    }
}
