namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing task template.
    /// </summary>
    internal class TaskTemplateUpdateMutation : Mutation<TaskTemplateUpdatePayload, TaskTemplateUpdateInput>
    {
        /// <summary>
        /// Initialize an new TaskTemplateUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal TaskTemplateUpdateMutation(TaskTemplateUpdateInput data, TaskTemplateQuery query)
            : base("taskTemplateUpdate", "TaskTemplateUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TaskTemplateQuery query)
        {
            query.FieldName = "taskTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
