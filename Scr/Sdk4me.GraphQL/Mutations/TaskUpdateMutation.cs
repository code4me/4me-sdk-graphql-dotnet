using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing task.
    /// </summary>
    internal class TaskUpdateMutation : Mutation<TaskUpdatePayload, TaskUpdateInput>
    {
        /// <summary>
        /// Initialize an new TaskUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The task response query.</param>
        internal TaskUpdateMutation(TaskUpdateInput data, TaskQuery query)
            : base("taskUpdate", "TaskUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The task response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TaskQuery query)
        {
            query.FieldName = "task";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
