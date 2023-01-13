namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new knowledge article.
    /// </summary>
    internal class KnowledgeArticleCreateMutation : Mutation<KnowledgeArticleCreatePayload, KnowledgeArticleCreateInput>
    {
        /// <summary>
        /// Initialize an new KnowledgeArticleCreate mutation instance.
        /// </summary>
        internal KnowledgeArticleCreateMutation(KnowledgeArticleCreateInput data)
            : base("knowledgeArticleCreate", "KnowledgeArticleCreateInput!", data, new HashSet<IQuery>() { new KnowledgeArticleQuery() { FieldName = "knowledgeArticle", IsConnection = false }.Select("*") })
        {
        }
    }
}
