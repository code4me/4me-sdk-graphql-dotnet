namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appofferingautomationrulecreatepayload/">AppOfferingAutomationRuleCreatePayload</see> object.
    /// </summary>
    public class AppOfferingAutomationRuleCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appOfferingAutomationRule"), Sdk4meField(true)]
        public AppOfferingAutomationRule? AppOfferingAutomationRule { get; internal set; }
    }
}
