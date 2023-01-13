namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new workflow type.
    /// </summary>
    internal class WorkflowTypeCreateMutation : Mutation<WorkflowTypeCreatePayload, WorkflowTypeCreateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowTypeCreate mutation instance.
        /// </summary>
        internal WorkflowTypeCreateMutation(WorkflowTypeCreateInput data)
            : base("workflowTypeCreate", "WorkflowTypeCreateInput!", data, new HashSet<IQuery>() { new WorkflowTypeQuery() { FieldName = "workflowType", IsConnection = false }.Select("*") })
        {
        }
    }
}
