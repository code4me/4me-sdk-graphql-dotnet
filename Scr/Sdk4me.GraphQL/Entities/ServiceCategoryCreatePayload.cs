namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/servicecategorycreatepayload/">ServiceCategoryCreatePayload</see> object.
    /// </summary>
    public class ServiceCategoryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceCategory"), Sdk4meField(true)]
        public ServiceCategory? ServiceCategory { get; internal set; }
    }
}
