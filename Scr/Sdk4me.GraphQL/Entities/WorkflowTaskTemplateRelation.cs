using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowtasktemplaterelation/">WorkflowTaskTemplateRelation</see> object.
    /// </summary>
    public class WorkflowTaskTemplateRelation : Node, IHasAutomationRules
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
        /// The template of the task that will be assigned in case this task is failed or rejected.
        /// </summary>
        [JsonProperty("failureTaskTemplate")]
        public TaskTemplate? FailureTaskTemplate { get; internal set; }

        /// <summary>
        /// The phase of the workflow template that the workflow task template is a part of.
        /// </summary>
        [JsonProperty("phase"), Sdk4meField(true)]
        public WorkflowTemplatePhase? Phase { get; internal set; }

        /// <summary>
        /// Task template related to the workflow template.
        /// </summary>
        [JsonProperty("taskTemplate"), Sdk4meField(true)]
        public TaskTemplate? TaskTemplate { get; internal set; }

        /// <summary>
        /// Workflow template related to the task template.
        /// </summary>
        [JsonProperty("workflowTemplate"), Sdk4meField(true)]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AutomationRules?.AddRange((data as WorkflowTaskTemplateRelation)?.AutomationRules);
        }
    }
}
