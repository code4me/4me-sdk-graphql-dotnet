namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new task.
    /// </summary>
    internal class TaskCreateMutation : Mutation<TaskCreatePayload, TaskCreateInput>
    {
        /// <summary>
        /// Initialize an new TaskCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal TaskCreateMutation(TaskCreateInput data, TaskQuery query)
            : base("taskCreate", "TaskCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TaskQuery query)
        {
            query.FieldName = "task";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
