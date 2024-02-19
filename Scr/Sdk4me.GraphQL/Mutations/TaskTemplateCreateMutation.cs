namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new task template.
    /// </summary>
    internal class TaskTemplateCreateMutation : Mutation<TaskTemplateCreatePayload, TaskTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new TaskTemplateCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal TaskTemplateCreateMutation(TaskTemplateCreateInput data, TaskTemplateQuery query)
            : base("taskTemplateCreate", "TaskTemplateCreateInput!", data, GetQuery(query))
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
