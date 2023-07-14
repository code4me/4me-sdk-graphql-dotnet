namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProjectCategory records.
    /// </summary>
    public class ProjectCategoryQuery : Query<ProjectCategoryQuery, ProjectCategoryField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new project category query instance.
        /// </summary>
        public ProjectCategoryQuery()
            : base("projectCategories", typeof(ProjectCategory), true)
        {
        }

        /// <summary>
        /// Initialize a new project category query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the project category.</param>
        public ProjectCategoryQuery(string id)
            : base("ProjectCategory", id, typeof(ProjectCategory), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ProjectCategoryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public ProjectCategoryQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }
    }
}
