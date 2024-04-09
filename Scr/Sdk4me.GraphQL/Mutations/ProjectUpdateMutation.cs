namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing project.
    /// </summary>
    internal class ProjectUpdateMutation : Mutation<ProjectUpdatePayload, ProjectUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProjectUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The project response query.</param>
        internal ProjectUpdateMutation(ProjectUpdateInput data, ProjectQuery query)
            : base("projectUpdate", "ProjectUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The project response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectQuery query)
        {
            query.FieldName = "project";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
