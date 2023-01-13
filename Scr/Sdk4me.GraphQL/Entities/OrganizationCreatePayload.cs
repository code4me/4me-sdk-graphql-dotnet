namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/organizationcreatepayload/">OrganizationCreatePayload</see> object.
    /// </summary>
    public class OrganizationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("organization"), Sdk4meField(true)]
        public Organization? Organization { get; internal set; }
    }
}
