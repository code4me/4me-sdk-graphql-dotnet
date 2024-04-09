namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project risk level.
    /// </summary>
    internal class ProjectRiskLevelCreateMutation : Mutation<ProjectRiskLevelCreatePayload, ProjectRiskLevelCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectRiskLevelCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The project risk level response query.</param>
        internal ProjectRiskLevelCreateMutation(ProjectRiskLevelCreateInput data, ProjectRiskLevelQuery query)
            : base("projectRiskLevelCreate", "ProjectRiskLevelCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The project risk level response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectRiskLevelQuery query)
        {
            query.FieldName = "projectRiskLevel";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
