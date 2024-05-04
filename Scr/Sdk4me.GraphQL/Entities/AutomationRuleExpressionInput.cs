using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/automationruleexpressioninput/">AutomationRuleExpressionInput</see> object.
    /// </summary>
    public class AutomationRuleExpressionInput : PropertyChangeSet
    {
        private string? name;
        private string? datavalue;

        /// <summary>
        /// Name of the expression, which can be used to refer to the expression from the rule's conditions, actions, or from other expressions.'
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The value of the expression. Refer to the 4me Help for guidance on how to form valid expressions.
        /// </summary>
        [JsonProperty("value")]
        public string? Value
        {
            get => datavalue;
            set => datavalue = Set("value", value);
        }
    }
}
