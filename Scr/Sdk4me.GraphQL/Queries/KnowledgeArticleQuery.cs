namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving KnowledgeArticle records.
    /// </summary>
    public class KnowledgeArticleQuery : Query<KnowledgeArticleQuery, KnowledgeArticleField, KnowledgeArticleView, KnowledgeArticleOrderField>
    {
        /// <summary>
        /// Initialize a new knowledge article query instance.
        /// </summary>
        public KnowledgeArticleQuery()
            : base("knowledgeArticles", typeof(KnowledgeArticle), true)
        {
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public KnowledgeArticleQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public KnowledgeArticleQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Requests linked to this knowledge article.
        /// </summary>
        public KnowledgeArticleQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// Services linked to this knowledge article.
        /// </summary>
        public KnowledgeArticleQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public KnowledgeArticleQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
