using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Used by <see cref="JsonSerializer"/> to resolve a <see cref="JsonContract"/> for a given <see cref="System.Type"/>.
    /// </summary>
    public sealed class MutationQueryContractResolver : DefaultContractResolver
    {
        private readonly ImmutableHashSet<string> fields;
        private readonly Type inputType;

        /// <summary>
        /// Get all fields that will be serialized.
        /// </summary>
        public ImmutableHashSet<string> Fields
        {
            get => fields;
        }

        /// <summary>
        /// Create a new instance of the <see cref="MutationQueryContractResolver"/> class.
        /// </summary>
        /// <param name="fields">The list of fields to serialize.</param>
        /// <param name="inputType">The data input <see cref="Type"/>. For any other type the data will be serialized.</param>
        public MutationQueryContractResolver(ImmutableHashSet<string> fields, Type inputType)
        {
            this.fields = fields;
            this.inputType = inputType;
        }

        /// <summary>
        /// <br>Creates a <see cref="JsonProperty"/> for the given <see cref="MemberInfo"/>.</br>
        /// <br>Only items in the <see cref="Fields"/> collection will be serialized.</br>
        /// </summary>
        /// <param name="memberSerialization">The member's parent <see cref="MemberSerialization"/>.</param>
        /// <param name="member">The member to create a <see cref="JsonProperty"/> for.</param>
        /// <returns>A created <see cref="JsonProperty"/> for the given <see cref="MemberInfo"/>.</returns>
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            property.ShouldSerialize = instance =>
            {
                return property.DeclaringType != inputType || (property.PropertyName != null && fields.Contains(property.PropertyName));
            };
            return property;
        }
    }
}
