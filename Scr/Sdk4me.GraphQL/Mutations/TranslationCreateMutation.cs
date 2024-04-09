namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new translation.
    /// </summary>
    internal class TranslationCreateMutation : Mutation<TranslationCreatePayload, TranslationCreateInput>
    {
        /// <summary>
        /// Initialize an new TranslationCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The translation response query.</param>
        internal TranslationCreateMutation(TranslationCreateInput data, TranslationQuery query)
            : base("translationCreate", "TranslationCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The translation response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TranslationQuery query)
        {
            query.FieldName = "translation";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
