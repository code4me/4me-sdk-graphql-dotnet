using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/servicecreatepayload/">ServiceCreatePayload</see> object.
    /// </summary>
    public class ServiceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Service? Service { get; internal set; }
    }
}
