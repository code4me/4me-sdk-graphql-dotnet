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
        internal ProjectRiskLevelCreateMutation(ProjectRiskLevelCreateInput data)
            : base("projectRiskLevelCreate", "ProjectRiskLevelCreateInput!", data, new HashSet<IQuery>() { new ProjectRiskLevelQuery() { FieldName = "projectRiskLevel", IsConnection = false }.Select("*") })
        {
        }
    }
}
