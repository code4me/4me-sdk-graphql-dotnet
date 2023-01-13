namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowPhase">WorkflowPhase</see> query.
    /// </summary>
    public class WorkflowPhaseQuery : Query<WorkflowPhaseQuery, WorkflowPhaseField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new workflow phase query instance.
        /// </summary>
        public WorkflowPhaseQuery()
            : base("", typeof(WorkflowPhase), true)
        {
        }
    }
}
