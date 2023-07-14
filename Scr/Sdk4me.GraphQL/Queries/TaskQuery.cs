namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Task records.
    /// </summary>
    public class TaskQuery : Query<TaskQuery, TaskField, TaskView, TaskOrderField>
    {
        /// <summary>
        /// Initialize a new task query instance.
        /// </summary>
        public TaskQuery()
            : base("tasks", typeof(Task), true)
        {
        }

        /// <summary>
        /// Initialize a new task query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the task.</param>
        public TaskQuery(string id)
            : base("Task", id, typeof(Task), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public TaskQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        public TaskQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        public TaskQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            query.FieldName = "agileBoardColumn";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Approvals of the task.
        /// </summary>
        public TaskQuery SelectApprovals(TaskApprovalQuery query)
        {
            query.FieldName = "approvals";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public TaskQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the task.
        /// </summary>
        public TaskQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public TaskQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public TaskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// The task that will be assigned in case this task is failed or rejected.
        /// </summary>
        public TaskQuery SelectFailureTask(TaskQuery query)
        {
            query.FieldName = "failureTask";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public TaskQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// The person to whom the task is to be assigned. This field's value is <c>null</c> in case of an approval task with multiple approvers.
        /// </summary>
        public TaskQuery SelectMember(PersonQuery query)
        {
            query.FieldName = "member";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public TaskQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// The order line related to the fulfillment task.
        /// </summary>
        public TaskQuery SelectOrderLine(ShopOrderLineQuery query)
        {
            query.FieldName = "orderLine";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The PDF design associated with the task.
        /// </summary>
        public TaskQuery SelectPdfDesign(PdfDesignQuery query)
        {
            query.FieldName = "pdfDesign";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The phase of the workflow to which the task belongs.
        /// </summary>
        public TaskQuery SelectPhase(WorkflowPhaseQuery query)
        {
            query.FieldName = "phase";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The request related to this task. When this request is solved the task will be completed.
        /// </summary>
        public TaskQuery SelectRequest(RequestQuery query)
        {
            query.FieldName = "request";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service instance that should be used to create the request for this task.
        /// </summary>
        public TaskQuery SelectRequestServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "requestServiceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The request template that should be used to create the request for this task.
        /// </summary>
        public TaskQuery SelectRequestTemplate(RequestTemplateQuery query)
        {
            query.FieldName = "requestTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service instances of the task.
        /// </summary>
        public TaskQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public TaskQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the task.
        /// </summary>
        public TaskQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The team to which the task is to be assigned.
        /// </summary>
        public TaskQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The task template that was used to register the task.
        /// </summary>
        public TaskQuery SelectTemplate(TaskTemplateQuery query)
        {
            query.FieldName = "template";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public TaskQuery SelectTimeEntries(TimeEntryQuery query)
        {
            query.FieldName = "timeEntries";
            return Select(query);
        }

        /// <summary>
        /// The workflow to which the task belongs.
        /// </summary>
        public TaskQuery SelectWorkflow(WorkflowQuery query)
        {
            query.FieldName = "workflow";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Task' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/taskcustomfilter/">4me developer site</see>.</br>
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
        public TaskQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
