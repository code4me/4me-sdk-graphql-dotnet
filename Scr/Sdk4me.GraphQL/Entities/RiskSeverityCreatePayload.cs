using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/riskseveritycreatepayload/">RiskSeverityCreatePayload</see> object.
    /// </summary>
    public class RiskSeverityCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("riskSeverity"), Sdk4meField(IsDefaultQueryProperty = true)]
        public RiskSeverity? RiskSeverity { get; internal set; }
    }
}
