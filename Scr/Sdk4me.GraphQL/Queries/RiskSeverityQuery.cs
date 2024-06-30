namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving RiskSeverity records.
    /// </summary>
    public class RiskSeverityQuery : Query<RiskSeverityQuery, RiskSeverityField, DefaultView, RiskSeverityFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new risk severity query instance.
        /// </summary>
        public RiskSeverityQuery()
            : base("riskSeverities", typeof(RiskSeverity), true)
        {
        }

        /// <summary>
        /// Initialize a new risk severity query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the risk severity.</param>
        public RiskSeverityQuery(string id)
            : base("RiskSeverity", id, typeof(RiskSeverity), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RiskSeverityQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RiskSeverityQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RiskSeverityQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
