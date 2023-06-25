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
        /// The account this record belongs to.
        /// </summary>
        public TranslationQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
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
