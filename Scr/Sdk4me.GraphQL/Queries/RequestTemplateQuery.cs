namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving RequestTemplate records.
    /// </summary>
    public class RequestTemplateQuery : Query<RequestTemplateQuery, RequestTemplateField, RequestTemplateView, RequestTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new request template query instance.
        /// </summary>
        public RequestTemplateQuery()
            : base("requestTemplates", typeof(RequestTemplate), true)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public RequestTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public RequestTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public RequestTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            query.FieldName = "noteAttachments";
            return Select(query);
        }

        /// <summary>
        /// Organizations related to the order request template.
        /// </summary>
        public RequestTemplateQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Registration hints field.
        /// </summary>
        public RequestTemplateQuery SelectRegistrationHintsAttachments(AttachmentQuery query)
        {
            query.FieldName = "registrationHintsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Requests created using the request template.
        /// </summary>
        public RequestTemplateQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// Reservation offerings related to the request template.
        /// </summary>
        public RequestTemplateQuery SelectReservationOfferings(ReservationOfferingQuery query)
        {
            query.FieldName = "reservationOfferings";
            return Select(query);
        }

        /// <summary>
        /// Standard service requests related to the request template.
        /// </summary>
        public RequestTemplateQuery SelectStandardServiceRequests(StandardServiceRequestQuery query)
        {
            query.FieldName = "standardServiceRequests";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public RequestTemplateQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
