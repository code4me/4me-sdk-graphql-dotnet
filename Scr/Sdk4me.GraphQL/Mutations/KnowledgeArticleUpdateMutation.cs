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
        /// <param name="data">The input data.</param>
        /// <param name="query">The knowledge article response query.</param>
        internal KnowledgeArticleUpdateMutation(KnowledgeArticleUpdateInput data, KnowledgeArticleQuery query)
            : base("knowledgeArticleUpdate", "KnowledgeArticleUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The knowledge article response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(KnowledgeArticleQuery query)
        {
            query.FieldName = "knowledgeArticle";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
