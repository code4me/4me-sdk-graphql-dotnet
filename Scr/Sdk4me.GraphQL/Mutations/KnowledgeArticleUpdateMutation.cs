namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing knowledge article.
    /// </summary>
    internal class KnowledgeArticleUpdateMutation : Mutation<KnowledgeArticleUpdatePayload, KnowledgeArticleUpdateInput>
    {
        /// <summary>
        /// Initialize an new KnowledgeArticleUpdate mutation instance.
        /// </summary>
        internal KnowledgeArticleUpdateMutation(KnowledgeArticleUpdateInput data)
            : base("knowledgeArticleUpdate", "KnowledgeArticleUpdateInput!", data, new HashSet<IQuery>() { new KnowledgeArticleQuery() { FieldName = "knowledgeArticle", IsConnection = false }.Select("*") })
        {
        }
    }
}
