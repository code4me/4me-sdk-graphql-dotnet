namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Workflow records.
    /// </summary>
    public class WorkflowQuery : Query<WorkflowQuery, WorkflowField, WorkflowView, WorkflowOrderField>
    {
        /// <summary>
        /// Initialize a new workflow query instance.
        /// </summary>
        public WorkflowQuery()
            : base("workflows", typeof(Workflow), true)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public WorkflowQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public WorkflowQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public WorkflowQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public WorkflowQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Phases of the workflow.
        /// </summary>
        public WorkflowQuery SelectPhases(WorkflowPhaseQuery query)
        {
            query.FieldName = "phases";
            return Select(query);
        }

        /// <summary>
        /// All problems of this workflow.
        /// </summary>
        public WorkflowQuery SelectProblems(ProblemQuery query)
        {
            query.FieldName = "problems";
            return Select(query);
        }

        /// <summary>
        /// All requests of this workflow.
        /// </summary>
        public WorkflowQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// All tasks of this workflow.
        /// </summary>
        public WorkflowQuery SelectTasks(TaskQuery query)
        {
            query.FieldName = "tasks";
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Workflow' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/workflowcustomfilter/">4me developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.
        /// <br>Use value null to indicate "None".</br>
        /// <br></br>
        /// <br>For "text" fields:</br>
        /// <br>- One can start the value with ~ to get partial matches (start with '~ to match on a value starting with ~).</br>
        /// <br></br>
        /// <br>For "number" and "time" fields:</br>
        /// <br>- One can start the value with &lt;, &gt;, &lt;=, &gt;= to get relative matches.</br>
        /// <br>- Times should be formatted as HH:mm:ss (e.g. 16:00:00). The seconds part, :ss, is optional so 16:00 is also valid.</br>
        /// <br>- &gt;{lower}&lt;{upper} can be used to get matches where the value is more than '{lower}' and less than '{upper}'.</br>
        /// <br>- &gt;={lower}&lt;={upper} can be used to get matches where the value is between '{lower}' and '{upper}'.</br>
        /// <br>- &gt;={lower}&lt;{upper} can be used to get matches where the value is at least '{lower}' and less than '{upper}'.</br>
        /// <br></br>
        /// <br>For "date" and "date-time" fields:</br>
        /// <br>- One must supply a single value (and null is not supported).</br>
        /// <br>- Matches are always relative with an optional upper bound.</br>
        /// <br>- Dates should be formatted as yyyy-MM-dd (e.g. 2020-05-20).</br>
        /// <br>- Date and time should be formatted as yyyy-MM-ddTHH:mm:ssZ (e.g. 2020-05-20T16:00:00Z).</br>
        /// <br>- &gt;={lower} should be used to get matches where the value is at least '{lower}'.</br>
        /// <br>- &gt;={lower}&lt;{upper} can be used to get matches where the value is at least '{lower}' and before '{upper}'.</br>
        /// <br></br>
        /// <br>Matches are case-sensitive.</br>
        /// </param>
        /// <exception cref="NullReferenceException"></exception>
        public WorkflowQuery CustomFilter(string name, FilterOperator filterOperator, params string[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
