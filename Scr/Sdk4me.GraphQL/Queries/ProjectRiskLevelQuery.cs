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
        /// Initialize a new project risk level query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the project risk level.</param>
        public ProjectRiskLevelQuery(string id)
            : base("ProjectRiskLevel", id, typeof(ProjectRiskLevel), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectRiskLevelQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectRiskLevelQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }
    }
}
