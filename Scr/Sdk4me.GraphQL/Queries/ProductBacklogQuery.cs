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
        /// Initialize a new product backlog query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the product backlog.</param>
        public ProductBacklogQuery(string id)
            : base("ProductBacklog", id, typeof(ProductBacklog), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ProductBacklogQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
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
        /// Person responsible for maximizing the value of the work done based on this product backlog.
        /// </summary>
        public ProductBacklogQuery SelectProductOwner(PersonQuery query)
        {
            query.FieldName = "productOwner";
            query.IsConnection = false;
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
