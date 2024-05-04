using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/automationrulecreatepayload/">AutomationRuleCreatePayload</see> object.
    /// </summary>
    public class AutomationRuleCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("automationRule"), Sdk4meField(true)]
        public AutomationRule? AutomationRule { get; internal set; }
    }
}
