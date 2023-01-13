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
        internal TranslationUpdateMutation(TranslationUpdateInput data)
            : base("translationUpdate", "TranslationUpdateInput!", data, new HashSet<IQuery>() { new TranslationQuery() { FieldName = "translation", IsConnection = false }.Select("*") })
        {
        }
    }
}
