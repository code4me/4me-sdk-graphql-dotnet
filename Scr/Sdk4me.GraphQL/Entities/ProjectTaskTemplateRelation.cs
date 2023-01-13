namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttasktemplaterelation/">ProjectTaskTemplateRelation</see> object.
    /// </summary>
    public class ProjectTaskTemplateRelation : Node
    {
        [JsonProperty("automationRules")]
        internal NodeCollection<AutomationRule>? AutomationRulesCollection { get; set; }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public DataList<AutomationRule>? AutomationRules
        {
            get => AutomationRulesCollection?.Data;
        }

        /// <summary>
        /// The phase of the project template that the project task template is a part of.
        /// </summary>
        [JsonProperty("phase"), Sdk4meField(true)]
        public ProjectTemplatePhase? Phase { get; internal set; }

        /// <summary>
        /// The project task template that is related to the project template.
        /// </summary>
        [JsonProperty("taskTemplate"), Sdk4meField(true)]
        public ProjectTaskTemplate? TaskTemplate { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AutomationRules?.AddRange((data as ProjectTaskTemplateRelation)?.AutomationRules);
        }
    }
}
