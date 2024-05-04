using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/requestupdatepayload/">RequestUpdatePayload</see> object.
    /// </summary>
    public class RequestUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("request"), Sdk4meField(true)]
        public Request? Request { get; internal set; }
    }
}
