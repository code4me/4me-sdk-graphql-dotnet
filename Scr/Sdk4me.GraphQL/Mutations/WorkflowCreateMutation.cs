namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new workflow.
    /// </summary>
    internal class WorkflowCreateMutation : Mutation<WorkflowCreatePayload, WorkflowCreateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowCreate mutation instance.
        /// </summary>
        internal WorkflowCreateMutation(WorkflowCreateInput data)
            : base("workflowCreate", "WorkflowCreateInput!", data, new HashSet<IQuery>() { new WorkflowQuery() { FieldName = "workflow", IsConnection = false }.Select("*") })
        {
        }
    }
}
