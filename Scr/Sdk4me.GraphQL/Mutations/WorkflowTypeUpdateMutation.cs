namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing workflow type.
    /// </summary>
    internal class WorkflowTypeUpdateMutation : Mutation<WorkflowTypeUpdatePayload, WorkflowTypeUpdateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowTypeUpdate mutation instance.
        /// </summary>
        internal WorkflowTypeUpdateMutation(WorkflowTypeUpdateInput data)
            : base("workflowTypeUpdate", "WorkflowTypeUpdateInput!", data, new HashSet<IQuery>() { new WorkflowTypeQuery() { FieldName = "workflowType", IsConnection = false }.Select("*") })
        {
        }
    }
}
