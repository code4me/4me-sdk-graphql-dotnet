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
        /// Service instances that are applied to knowledge articles using this template.
        /// </summary>
        public KnowledgeArticleTemplateQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }
    }
}
