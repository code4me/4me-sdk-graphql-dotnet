namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appofferingautomationruleupdateinput/">AppOfferingAutomationRuleUpdateInput</see> object.
    /// </summary>
    public class AppOfferingAutomationRuleUpdateInput : PropertyChangeSet
    {
        private List<AutomationRuleActionInput>? actions;
        private string? condition;
        private string? description;
        private List<AutomationRuleExpressionInput>? expressions;
        private string? generic;
        private string? name;
        private long? position;
        private string? trigger;
        private string? id;
        private string? clientMutationId;

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        [JsonProperty("actions")]
        public List<AutomationRuleActionInput>? Actions
        {
            get => actions;
            set => actions = Set("actions", value);
        }

        /// <summary>
        /// The Condition field is used to define the condition that needs to be met in order for the update action(s) of the rule to be performed. For example: <c>is_assigned and !badge</c>.
        /// </summary>
        [JsonProperty("condition")]
        public string? Condition
        {
            get => condition;
            set => condition = Set("condition", value);
        }

        /// <summary>
        /// A high-level description of the automation rule's function.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        [JsonProperty("expressions")]
        public List<AutomationRuleExpressionInput>? Expressions
        {
            get => expressions;
            set => expressions = Set("expressions", value);
        }

        /// <summary>
        /// <br>The record type this rule is linked to.</br>
        /// <br>Valid values are:</br>
        /// <br>• <c>request</c></br>
        /// <br>• <c>task</c></br>
        /// <br>• <c>ci</c></br>
        /// </summary>
        [JsonProperty("generic")]
        public string? Generic
        {
            get => generic;
            set => generic = Set("generic", value);
        }

        /// <summary>
        /// The name of the automation rule.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The Position field dictates the order in which the automation rule is executed.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
        }

        /// <summary>
        /// The Trigger field is used to specify when the automation rule is to be triggered, for example <c>on status update</c> or <c>on note added</c>.
        /// </summary>
        [JsonProperty("trigger")]
        public string? Trigger
        {
            get => trigger;
            set => trigger = Set("trigger", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }
    }
}
