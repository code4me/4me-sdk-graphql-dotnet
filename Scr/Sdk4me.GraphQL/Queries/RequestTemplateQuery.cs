namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving RequestTemplate records.
    /// </summary>
    public class RequestTemplateQuery : Query<RequestTemplateQuery, RequestTemplateField, RequestTemplateView, RequestTemplateFilter, RequestTemplateOrderField>
    {
        /// <summary>
        /// Initialize a new request template query instance.
        /// </summary>
        public RequestTemplateQuery()
            : base("requestTemplates", typeof(RequestTemplate), true)
        {
        }

        /// <summary>
        /// Initialize a new request template query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the request template.</param>
        public RequestTemplateQuery(string id)
            : base("RequestTemplate", id, typeof(RequestTemplate), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rule query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// The CI that needs to be copied to the Configuration item field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItem";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request that is based on the request template.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Used to select the person who should be selected in the Member field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectMember(PersonQuery query)
        {
            query.FieldName = "member";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectNoteAttachments(AttachmentQuery query)
        {
            query.FieldName = "noteAttachments";
            return Select(query);
        }

        /// <summary>
        /// Organizations related to the order request template.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Registration hints field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectRegistrationHintsAttachments(AttachmentQuery query)
        {
            query.FieldName = "registrationHintsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Requests created using the request template.
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// Reservation offerings related to the request template.
        /// </summary>
        /// <param name="query">The reservation offering query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectReservationOfferings(ReservationOfferingQuery query)
        {
            query.FieldName = "reservationOfferings";
            return Select(query);
        }

        /// <summary>
        /// The service for which the request template is made available.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Standard service requests related to the request template.
        /// </summary>
        /// <param name="query">The standard service request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectStandardServiceRequests(StandardServiceRequestQuery query)
        {
            query.FieldName = "standardServiceRequests";
            return Select(query);
        }

        /// <summary>
        /// Used to select the supplier organization that should be selected in the Supplier field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that is to be used to calculate the desired completion for requests that are based on the request template.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectSupportHours(CalendarQuery query)
        {
            query.FieldName = "supportHours";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The team that should be selected in the Team field of a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is to be added to a new request when it is being created based on the template.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to relate a Workflow Manager to the request template. <em>Required</em> when a Workflow Template is defined, and the Service does not define a Workflow Manager.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectWorkflowManager(PersonQuery query)
        {
            query.FieldName = "workflowManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to relate a Workflow Template to the request template. <em>Required</em> when the <em>Status</em> is set to _Workflow Pending_.
        /// </summary>
        /// <param name="query">The workflow template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public RequestTemplateQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplate";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
