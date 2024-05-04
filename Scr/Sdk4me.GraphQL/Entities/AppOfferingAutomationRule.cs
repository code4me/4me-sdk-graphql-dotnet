using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appofferingautomationrule/">AppOfferingAutomationRule</see> object.
    /// </summary>
    public class AppOfferingAutomationRule : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        [JsonProperty("actions"), Sdk4meField(true)]
        public List<AutomationRuleAction>? Actions { get; internal set; }

        /// <summary>
        /// AppOffering this rule belongs to.
        /// </summary>
        [JsonProperty("appOffering"), Sdk4meField(true)]
        public AppOffering? AppOffering { get; internal set; }

        /// <summary>
        /// The Condition field is used to define the condition that needs to be met in order for the update action(s) of the rule to be performed. For example: <c>is_assigned and !badge</c>.
        /// </summary>
        [JsonProperty("condition")]
        public string? Condition { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// A high-level description of the automation rule's function.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        [JsonProperty("expressions")]
        public List<AutomationRuleExpression>? Expressions { get; internal set; }

        /// <summary>
        /// <br>The record type this rule is linked to.</br>
        /// <br>Valid values are:</br>
        /// <br>• <c>request</c></br>
        /// <br>• <c>task</c></br>
        /// <br>• <c>ci</c></br>
        /// </summary>
        [JsonProperty("generic"), Sdk4meField(true)]
        public string? Generic { get; internal set; }

        /// <summary>
        /// The name of the automation rule.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The Position field dictates the order in which the automation rule is executed.
        /// </summary>
        [JsonProperty("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// The Trigger field is used to specify when the automation rule is to be triggered, for example <c>on status update</c> or <c>on note added</c>.
        /// </summary>
        [JsonProperty("trigger"), Sdk4meField(true)]
        public string? Trigger { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
