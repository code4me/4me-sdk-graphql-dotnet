using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/riskupdatepayload/">RiskUpdatePayload</see> object.
    /// </summary>
    public class RiskUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("risk"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Risk? Risk { get; internal set; }
    }
}
