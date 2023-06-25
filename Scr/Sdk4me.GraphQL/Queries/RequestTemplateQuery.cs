﻿namespace Sdk4me.GraphQL
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
        /// The account this record belongs to.
        /// </summary>
        public RequestTemplateQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
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
        /// The CI that needs to be copied to the Configuration item field of a new request when it is being created based on the template.
        /// </summary>
        public RequestTemplateQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItem";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request that is based on the request template.
        /// </summary>
        public RequestTemplateQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
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
        /// Used to select the person who should be selected in the Member field of a new request when it is being created based on the template.
        /// </summary>
        public RequestTemplateQuery SelectMember(PersonQuery query)
        {
            query.FieldName = "member";
            query.IsConnection = false;
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
        /// The service for which the request template is made available.
        /// </summary>
        public RequestTemplateQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
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
        /// Used to select the supplier organization that should be selected in the Supplier field of a new request when it is being created based on the template.
        /// </summary>
        public RequestTemplateQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that is to be used to calculate the desired completion for requests that are based on the request template.
        /// </summary>
        public RequestTemplateQuery SelectSupportHours(CalendarQuery query)
        {
            query.FieldName = "supportHours";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The team that should be selected in the Team field of a new request when it is being created based on the template.
        /// </summary>
        public RequestTemplateQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
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

        /// <summary>
        /// UI extension that is to be added to a new request when it is being created based on the template.
        /// </summary>
        public RequestTemplateQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to relate a Workflow Manager to the request template. <em>Required</em> when a Workflow Template is defined, and the Service does not define a Workflow Manager.
        /// </summary>
        public RequestTemplateQuery SelectWorkflowManager(PersonQuery query)
        {
            query.FieldName = "workflowManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to relate a Workflow Template to the request template. <em>Required</em> when the <em>Status</em> is set to _Workflow Pending_.
        /// </summary>
        public RequestTemplateQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplate";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
