using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/serviceupdatepayload/">ServiceUpdatePayload</see> object.
    /// </summary>
    public class ServiceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Service? Service { get; internal set; }
    }
}
