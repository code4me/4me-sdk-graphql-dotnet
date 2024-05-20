using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appofferingautomationruleupdatepayload/">AppOfferingAutomationRuleUpdatePayload</see> object.
    /// </summary>
    public class AppOfferingAutomationRuleUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appOfferingAutomationRule"), Sdk4meField(IsDefaultQueryProperty = true)]
        public AppOfferingAutomationRule? AppOfferingAutomationRule { get; internal set; }
    }
}
