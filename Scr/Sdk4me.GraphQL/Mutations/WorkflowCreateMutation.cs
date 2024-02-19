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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal WorkflowCreateMutation(WorkflowCreateInput data, WorkflowQuery query)
            : base("workflowCreate", "WorkflowCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WorkflowQuery query)
        {
            query.FieldName = "workflow";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
