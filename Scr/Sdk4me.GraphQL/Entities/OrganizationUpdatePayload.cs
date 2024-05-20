using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/organizationupdatepayload/">OrganizationUpdatePayload</see> object.
    /// </summary>
    public class OrganizationUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("organization"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Organization? Organization { get; internal set; }
    }
}
