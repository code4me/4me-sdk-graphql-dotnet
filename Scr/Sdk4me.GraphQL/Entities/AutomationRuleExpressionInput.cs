using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/automationruleexpressioninput/">AutomationRuleExpressionInput</see> object.
    /// </summary>
    public class AutomationRuleExpressionInput : PropertyChangeSet
    {
        private string name;
        private string value;

        /// <summary>
        /// Name of the expression, which can be used to refer to the expression from the rule's conditions, actions, or from other expressions.'
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The value of the expression. Refer to the 4me Help for guidance on how to form valid expressions.
        /// </summary>
        [JsonProperty("value")]
        public string Value
        {
            get => value;
            set => this.value = Set("value", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleExpressionInput"/> class without providing the required values.
        /// </summary>
        public AutomationRuleExpressionInput()
        {
            name = string.Empty;
            value = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleExpressionInput"/> class.
        /// </summary>
        /// <param name="name">Name of the expression, which can be used to refer to the expression from the rule's conditions, actions, or from other expressions.'</param>
        /// <param name="value">The value of the expression. Refer to the 4me Help for guidance on how to form valid expressions.</param>
        public AutomationRuleExpressionInput(string name, string value)
        {
            this.name = Set("name", name);
            this.value = Set("value", value);
        }
    }
}
