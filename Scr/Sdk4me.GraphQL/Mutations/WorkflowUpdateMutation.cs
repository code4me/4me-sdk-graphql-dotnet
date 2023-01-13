namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing workflow.
    /// </summary>
    internal class WorkflowUpdateMutation : Mutation<WorkflowUpdatePayload, WorkflowUpdateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowUpdate mutation instance.
        /// </summary>
        internal WorkflowUpdateMutation(WorkflowUpdateInput data)
            : base("workflowUpdate", "WorkflowUpdateInput!", data, new HashSet<IQuery>() { new WorkflowQuery() { FieldName = "workflow", IsConnection = false }.Select("*") })
        {
        }
    }
}
