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
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal WorkflowUpdateMutation(WorkflowUpdateInput data, WorkflowQuery query)
            : base("workflowUpdate", "WorkflowUpdateInput!", data, GetQuery(query))
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
