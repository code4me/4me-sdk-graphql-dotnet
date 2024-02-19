namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing workflow template.
    /// </summary>
    internal class WorkflowTemplateUpdateMutation : Mutation<WorkflowTemplateUpdatePayload, WorkflowTemplateUpdateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowTemplateUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal WorkflowTemplateUpdateMutation(WorkflowTemplateUpdateInput data, WorkflowTemplateQuery query)
            : base("workflowTemplateUpdate", "WorkflowTemplateUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
