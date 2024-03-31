namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing translation.
    /// </summary>
    internal class TranslationUpdateMutation : Mutation<TranslationUpdatePayload, TranslationUpdateInput>
    {
        /// <summary>
        /// Initialize an new TranslationUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal TranslationUpdateMutation(TranslationUpdateInput data, TranslationQuery query)
            : base("translationUpdate", "TranslationUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TranslationQuery query)
        {
            query.FieldName = "translation";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
