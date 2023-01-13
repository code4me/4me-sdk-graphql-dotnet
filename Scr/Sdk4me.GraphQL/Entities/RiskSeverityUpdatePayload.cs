namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/riskseverityupdatepayload/">RiskSeverityUpdatePayload</see> object.
    /// </summary>
    public class RiskSeverityUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("riskSeverity"), Sdk4meField(true)]
        public RiskSeverity? RiskSeverity { get; internal set; }
    }
}
