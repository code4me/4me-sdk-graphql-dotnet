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
        /// Initialize a new request query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the request.</param>
        public RequestQuery(string id)
            : base("Request", id, typeof(Request), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public RequestQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Affected SLAs of the request.
        /// </summary>
        public RequestQuery SelectAffectedSlas(AffectedSlaQuery query)
        {
            query.FieldName = "affectedSlas";
            return Select(query);
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        public RequestQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        public RequestQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            query.FieldName = "agileBoardColumn";
            query.IsConnection = false;
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
        /// Automatically set to the person who submitted the request.
        /// </summary>
        public RequestQuery SelectCreatedBy(PersonQuery query)
        {
            query.FieldName = "createdBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public RequestQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
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
        /// The <c>satisfiedUrl</c> and the <c>dissatisfiedUrl</c> of the <c>requestedFor</c>. In case the <c>requestedBy</c> is different form the <c>requestedFor</c>, the satisfaction link of the <c>requestedBy</c> are also included. Feedback is <c>null</c> in case no feedback for the request can be provided at this time.
        /// </summary>
        public RequestQuery SelectFeedback(FeedbackQuery query)
        {
            query.FieldName = "feedback";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The request group that is used to group the requests that have been submitted for the resolution of exactly the same incident, for the implementation of exactly the same change, for the provision of exactly the same information, etc.
        /// </summary>
        public RequestQuery SelectGroupedInto(RequestQuery query)
        {
            query.FieldName = "groupedInto";
            query.IsConnection = false;
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
        /// Automatically set to the latest knowledge article that was applied to the request.
        /// </summary>
        public RequestQuery SelectKnowledgeArticle(KnowledgeArticleQuery query)
        {
            query.FieldName = "knowledgeArticle";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Knowledge articles of the current request account.
        /// </summary>
        public RequestQuery SelectKnowledgeArticles(KnowledgeArticleQuery query)
        {
            query.FieldName = "knowledgeArticles";
            return Select(query);
        }

        /// <summary>
        /// The person to whom the request is to be assigned.
        /// </summary>
        public RequestQuery SelectMember(PersonQuery query)
        {
            query.FieldName = "member";
            query.IsConnection = false;
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
        /// Automatically set when the request is saved for the first time to the organization that the person, who is selected in the Requested for field, belongs.
        /// </summary>
        public RequestQuery SelectOrganization(OrganizationQuery query)
        {
            query.FieldName = "organization";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to link the request to a problem.
        /// </summary>
        public RequestQuery SelectProblem(ProblemQuery query)
        {
            query.FieldName = "problem";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Product backlog this item is placed on.
        /// </summary>
        public RequestQuery SelectProductBacklog(ProductBacklogQuery query)
        {
            query.FieldName = "productBacklog";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to link the request to a project.
        /// </summary>
        public RequestQuery SelectProject(ProjectQuery query)
        {
            query.FieldName = "project";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who submitted the request.
        /// </summary>
        public RequestQuery SelectRequestedBy(PersonQuery query)
        {
            query.FieldName = "requestedBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person for whom the request was submitted. The person selected in the Requested by field is automatically selected in this field, but another person can be selected if the request is submitted for another person.
        /// </summary>
        public RequestQuery SelectRequestedFor(PersonQuery query)
        {
            query.FieldName = "requestedFor";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service instance in which the cause of the incident resides, for which the change is requested, or about which information is needed.
        /// </summary>
        public RequestQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
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
        /// The supplier organization that has been asked to assist with the request. The supplier organization is automatically selected in this field after a service instance has been selected that is provided by an external service provider organization.
        /// </summary>
        public RequestQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The task that caused the request to be automatically generated.
        /// </summary>
        public RequestQuery SelectTask(TaskQuery query)
        {
            query.FieldName = "task";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The team to which the request is to be assigned. By default, the first line team of the service instance that is related to the request will be selected. If a first line team has not been specified for the service instance, the support team of the service instance will be selected instead.
        /// </summary>
        public RequestQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The link to the request template that was last applied to the request.
        /// </summary>
        public RequestQuery SelectTemplate(RequestTemplateQuery query)
        {
            query.FieldName = "template";
            query.IsConnection = false;
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

        /// <summary>
        /// List of all people watching the request.
        /// </summary>
        public RequestQuery SelectWatches(WatchQuery query)
        {
            query.FieldName = "watches";
            return Select(query);
        }

        /// <summary>
        /// Used to link the request to a workflow.
        /// </summary>
        public RequestQuery SelectWorkflow(WorkflowQuery query)
        {
            query.FieldName = "workflow";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Request' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/requestcustomfilter/">4me developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.
        /// <br>Use value <c>null</c> to indicate "None".</br>
        /// <br></br>
        /// <br>For "text" fields:</br>
        /// <br>• One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).</br>
        /// <br></br>
        /// <br>For "number" and "time" fields:</br>
        /// <br>• One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.</br>
        /// <br>• Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.</br>
        /// <br>• <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.</br>
        /// <br>• <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.</br>
        /// <br>• <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.</br>
        /// <br></br>
        /// <br>For "date" and "date-time" fields:</br>
        /// <br>• One must supply a single value (and <c>null</c> is not supported).</br>
        /// <br>• Matches are always relative with an optional upper bound.</br>
        /// <br>• Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).</br>
        /// <br>• Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).</br>
        /// <br>• <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.</br>
        /// <br>• <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.</br>
        /// <br></br>
        /// <br>For "select" fields:</br>
        /// <br>• One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).</br>
        /// <br>• Matches are case-sensitive.</br>
        /// </param>
        /// <exception cref="NullReferenceException"></exception>
        public RequestQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
