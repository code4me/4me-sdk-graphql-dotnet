using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/serviceinstanceupdatepayload/">ServiceInstanceUpdatePayload</see> object.
    /// </summary>
    public class ServiceInstanceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceInstance"), Sdk4meField(true)]
        public ServiceInstance? ServiceInstance { get; internal set; }
    }
}
