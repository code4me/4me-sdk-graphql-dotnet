namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/automationrule/">AutomationRule</see> object.
    /// </summary>
    public class AutomationRule : Node
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
        /// The Condition field is used to define the condition that needs to be met in order for the update action(s) of the rule to be performed. For example: <c>is_assigned and !badge</c>.
        /// </summary>
        [JsonProperty("condition"), Sdk4meField(true)]
        public string? Condition { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// 'A high-level description of the automation rule's function.'
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// Whether the automation rule should not be triggered.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        [JsonProperty("expressions")]
        public List<AutomationRuleExpression>? Expressions { get; internal set; }

        /// <summary>
        /// <br>When the automation rule is not linked to one specific record but to all records of a type, the Generic field contains the record type.</br>
        /// <br>Valid values are:</br>
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
        [JsonProperty("generic"), Sdk4meField(true)]
        public string? Generic { get; internal set; }

        /// <summary>
        /// The name of the automation rule.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// </summary>
        [JsonProperty("owner")]
        public IHasAutomationRules? Owner { get; internal set; }

        /// <summary>
        /// The Position field dictates the order in which the automation rule is executed.
        /// </summary>
        [JsonProperty("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

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
