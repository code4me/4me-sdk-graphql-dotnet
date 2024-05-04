using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/riskcreatepayload/">RiskCreatePayload</see> object.
    /// </summary>
    public class RiskCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("risk"), Sdk4meField(true)]
        public Risk? Risk { get; internal set; }
    }
}
