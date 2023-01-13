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
        internal TranslationCreateMutation(TranslationCreateInput data)
            : base("translationCreate", "TranslationCreateInput!", data, new HashSet<IQuery>() { new TranslationQuery() { FieldName = "translation", IsConnection = false }.Select("*") })
        {
        }
    }
}
