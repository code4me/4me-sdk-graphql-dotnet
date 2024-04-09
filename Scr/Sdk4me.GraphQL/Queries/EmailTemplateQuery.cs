namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="EmailTemplate">EmailTemplate</see> query.
    /// </summary>
    public class EmailTemplateQuery : Query<EmailTemplateQuery, EmailTemplateField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new email template query instance.
        /// </summary>
        public EmailTemplateQuery()
            : base("", typeof(EmailTemplate), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EmailTemplateQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EmailTemplateQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
