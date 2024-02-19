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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal WorkflowTypeCreateMutation(WorkflowTypeCreateInput data, WorkflowTypeQuery query)
            : base("workflowTypeCreate", "WorkflowTypeCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WorkflowTypeQuery query)
        {
            query.FieldName = "workflowType";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
