namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving RiskSeverity records.
    /// </summary>
    public class RiskSeverityQuery : Query<RiskSeverityQuery, RiskSeverityField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new risk severity query instance.
        /// </summary>
        public RiskSeverityQuery()
            : base("riskSeverities", typeof(RiskSeverity), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public RiskSeverityQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public RiskSeverityQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
