namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Request records.
    /// </summary>
    public class RequestQuery : Query<RequestQuery, RequestField, RequestView, RequestOrderField>
    {
        /// <summary>
        /// Initialize a new request query instance.
        /// </summary>
        public RequestQuery()
            : base("requests", typeof(Request), true)
        {
        }

        /// <summary>
        /// Affected service level agreements of the request.
        /// </summary>
        public RequestQuery SelectAffectedSlas(AffectedSlaQuery query)
        {
            query.FieldName = "affectedSlas";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public RequestQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the request.
        /// </summary>
        public RequestQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public RequestQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Requests that are grouped into this request group.
        /// </summary>
        public RequestQuery SelectGroupedRequests(RequestQuery query)
        {
            query.FieldName = "groupedRequests";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public RequestQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public RequestQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public RequestQuery SelectTimeEntries(TimeEntryQuery query)
        {
            query.FieldName = "timeEntries";
            return Select(query);
        }
    }
}
