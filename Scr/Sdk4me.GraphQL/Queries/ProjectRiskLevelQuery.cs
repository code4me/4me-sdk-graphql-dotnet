namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProjectRiskLevel records.
    /// </summary>
    public class ProjectRiskLevelQuery : Query<ProjectRiskLevelQuery, ProjectRiskLevelField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new project risk level query instance.
        /// </summary>
        public ProjectRiskLevelQuery()
            : base("projectRiskLevels", typeof(ProjectRiskLevel), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public ProjectRiskLevelQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }
    }
}
