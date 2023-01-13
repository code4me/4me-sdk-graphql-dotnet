namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Translation records.
    /// </summary>
    public class TranslationQuery : Query<TranslationQuery, TranslationField, TranslationView, TranslationOrderField>
    {
        /// <summary>
        /// Initialize a new translation query instance.
        /// </summary>
        public TranslationQuery()
            : base("translations", typeof(Translation), true)
        {
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(HasTranslationsQuery query)
        {
            query.FieldName = "owner";
            return Select(query);
        }
    }
}
