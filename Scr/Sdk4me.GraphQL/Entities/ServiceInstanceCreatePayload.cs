namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/serviceinstancecreatepayload/">ServiceInstanceCreatePayload</see> object.
    /// </summary>
    public class ServiceInstanceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceInstance"), Sdk4meField(true)]
        public ServiceInstance? ServiceInstance { get; internal set; }
    }
}
