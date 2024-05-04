using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project task.
    /// </summary>
    internal class ProjectTaskUpdateMutation : Mutation<ProjectTaskUpdatePayload, ProjectTaskUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTaskUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The project task response query.</param>
        internal ProjectTaskUpdateMutation(ProjectTaskUpdateInput data, ProjectTaskQuery query)
            : base("projectTaskUpdate", "ProjectTaskUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The project task response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectTaskQuery query)
        {
            query.FieldName = "projectTask";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
