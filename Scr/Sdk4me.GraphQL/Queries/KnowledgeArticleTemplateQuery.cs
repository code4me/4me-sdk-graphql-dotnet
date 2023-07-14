namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving KnowledgeArticleTemplate records.
    /// </summary>
    public class KnowledgeArticleTemplateQuery : Query<KnowledgeArticleTemplateQuery, KnowledgeArticleTemplateField, KnowledgeArticleTemplateView, KnowledgeArticleTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new knowledge article template query instance.
        /// </summary>
        public KnowledgeArticleTemplateQuery()
            : base("knowledgeArticleTemplates", typeof(KnowledgeArticleTemplate), true)
        {
        }

        /// <summary>
        /// Initialize a new knowledge article template query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the knowledge article template.</param>
        public KnowledgeArticleTemplateQuery(string id)
            : base("KnowledgeArticleTemplate", id, typeof(KnowledgeArticleTemplate), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public KnowledgeArticleTemplateQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service that is applied to knowledge articles using this template.
        /// </summary>
        public KnowledgeArticleTemplateQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service instances that are applied to knowledge articles using this template.
        /// </summary>
        public KnowledgeArticleTemplateQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// The UI extension that is applied to knowledge articles using this template.
        /// </summary>
        public KnowledgeArticleTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
