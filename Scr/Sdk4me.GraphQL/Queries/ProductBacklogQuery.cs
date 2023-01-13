namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProductBacklog records.
    /// </summary>
    public class ProductBacklogQuery : Query<ProductBacklogQuery, ProductBacklogField, ProductBacklogView, ProductBacklogOrderField>
    {
        /// <summary>
        /// Initialize a new product backlog query instance.
        /// </summary>
        public ProductBacklogQuery()
            : base("productBacklogs", typeof(ProductBacklog), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        public ProductBacklogQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Items on this backlog.
        /// </summary>
        public ProductBacklogQuery SelectItems(ProductBacklogItemQuery query)
        {
            query.FieldName = "items";
            return Select(query);
        }

        /// <summary>
        /// Scrum workspaces taking items from this backlog when planning their sprints.
        /// </summary>
        public ProductBacklogQuery SelectScrumWorkspaces(ScrumWorkspaceQuery query)
        {
            query.FieldName = "scrumWorkspaces";
            return Select(query);
        }
    }
}
