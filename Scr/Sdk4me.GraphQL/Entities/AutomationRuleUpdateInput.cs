using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/automationruleupdateinput/">AutomationRuleUpdateInput</see> object.
    /// </summary>
    public class AutomationRuleUpdateInput : PropertyChangeSet
    {
        private List<AutomationRuleActionInput>? actions;
        private string? clientMutationId;
        private string? condition;
        private string? description;
        private bool? disabled;
        private List<AutomationRuleExpressionInput>? expressions;
        private string? generic;
        private string id;
        private string? name;
        private string? ownerId;
        private long? position;
        private string? source;
        private string? sourceID;
        private string? trigger;

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
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
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
        /// Whether the automation rule should not be triggered.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
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
        /// <br>When the automation rule is not linked to one specific record but to all records of a type, the Generic field contains the record type. Valid values are:</br>
        /// <br>• <c>request</c></br>
        /// <br>• <c>problem</c></br>
        /// <br>• <c>workflow</c></br>
        /// <br>• <c>task</c></br>
        /// <br>• <c>project_task</c></br>
        /// <br>• <c>ci</c></br>
        /// <br>• <c>risk</c></br>
        /// <br>• <c>scim_user</c></br>
        /// <br>• <c>scim_group</c></br>
        /// </summary>
        [JsonProperty("generic")]
        public string? Generic
        {
            get => generic;
            set => generic = Set("generic", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
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
        /// The record that the automation rule is linked to.
        /// </summary>
        [JsonProperty("ownerId")]
        public string? OwnerId
        {
            get => ownerId;
            set => ownerId = Set("ownerId", value);
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
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
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
        /// Initializes a new instance of the <see cref="AutomationRuleUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public AutomationRuleUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
