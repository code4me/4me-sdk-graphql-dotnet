namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project.
    /// </summary>
    internal class ProjectCreateMutation : Mutation<ProjectCreatePayload, ProjectCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The project response query.</param>
        internal ProjectCreateMutation(ProjectCreateInput data, ProjectQuery query)
            : base("projectCreate", "ProjectCreateInput!", data, GetQuery(query))
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
