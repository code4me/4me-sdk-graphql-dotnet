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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal KnowledgeArticleCreateMutation(KnowledgeArticleCreateInput data, KnowledgeArticleQuery query)
            : base("knowledgeArticleCreate", "KnowledgeArticleCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(KnowledgeArticleQuery query)
        {
            query.FieldName = "knowledgeArticle";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
