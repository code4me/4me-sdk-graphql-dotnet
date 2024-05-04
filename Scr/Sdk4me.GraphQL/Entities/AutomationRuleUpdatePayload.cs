using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/automationruleupdatepayload/">AutomationRuleUpdatePayload</see> object.
    /// </summary>
    public class AutomationRuleUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("automationRule"), Sdk4meField(true)]
        public AutomationRule? AutomationRule { get; internal set; }
    }
}
