﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appofferingautomationrulecreateinput/">AppOfferingAutomationRuleCreateInput</see> object.
    /// </summary>
    public class AppOfferingAutomationRuleCreateInput : PropertyChangeSet
    {
        private List<AutomationRuleActionInput>? actions;
        private string appOfferingId;
        private string? clientMutationId;
        private string condition;
        private string? description;
        private List<AutomationRuleExpressionInput>? expressions;
        private string? generic;
        private string name;
        private long? position;
        private string trigger;

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
        /// Identifier of the app offering the rule belongs to.
        /// </summary>
        [JsonProperty("appOfferingId"), Sdk4meField(IsRequiredForMutation = true)]
        public string AppOfferingId
        {
            get => appOfferingId;
            set => appOfferingId = Set("appOfferingId", value);
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
        [JsonProperty("condition"), Sdk4meField(IsRequiredForMutation = true)]
        public string Condition
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
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
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
        [JsonProperty("trigger"), Sdk4meField(IsRequiredForMutation = true)]
        public string Trigger
        {
            get => trigger;
            set => trigger = Set("trigger", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleCreateInput"/> class without providing the required values.
        /// </summary>
        public AppOfferingAutomationRuleCreateInput()
        {
            appOfferingId = string.Empty;
            condition = string.Empty;
            name = string.Empty;
            trigger = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleCreateInput"/> class.
        /// </summary>
        /// <param name="appOfferingId">Identifier of the app offering the rule belongs to.</param>
        /// <param name="condition">The Condition field is used to define the condition that needs to be met in order for the update action(s) of the rule to be performed. For example: <c>is_assigned and !badge</c>.</param>
        /// <param name="name">The name of the automation rule.</param>
        /// <param name="trigger">The Trigger field is used to specify when the automation rule is to be triggered, for example <c>on status update</c> or <c>on note added</c>.</param>
        public AppOfferingAutomationRuleCreateInput(string appOfferingId, string condition, string name, string trigger)
        {
            this.appOfferingId = Set("appOfferingId", appOfferingId);
            this.condition = Set("condition", condition);
            this.name = Set("name", name);
            this.trigger = Set("trigger", trigger);
        }
    }
}
