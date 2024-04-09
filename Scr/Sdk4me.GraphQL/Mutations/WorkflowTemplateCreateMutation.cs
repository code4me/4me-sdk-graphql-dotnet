namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new workflow template.
    /// </summary>
    internal class WorkflowTemplateCreateMutation : Mutation<WorkflowTemplateCreatePayload, WorkflowTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowTemplateCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The workflow template response query.</param>
        internal WorkflowTemplateCreateMutation(WorkflowTemplateCreateInput data, WorkflowTemplateQuery query)
            : base("workflowTemplateCreate", "WorkflowTemplateCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The workflow template response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
