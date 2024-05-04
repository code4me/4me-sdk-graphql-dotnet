using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/servicecategoryupdatepayload/">ServiceCategoryUpdatePayload</see> object.
    /// </summary>
    public class ServiceCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceCategory"), Sdk4meField(true)]
        public ServiceCategory? ServiceCategory { get; internal set; }
    }
}
