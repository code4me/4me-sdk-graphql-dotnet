namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTemplatePhase">WorkflowTemplatePhase</see> query.
    /// </summary>
    public class WorkflowTemplatePhaseQuery : Query<WorkflowTemplatePhaseQuery, WorkflowTemplatePhaseField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new workflow template phase query instance.
        /// </summary>
        public WorkflowTemplatePhaseQuery()
            : base("", typeof(WorkflowTemplatePhase), true)
        {
        }
    }
}
