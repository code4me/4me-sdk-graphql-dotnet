namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProjectTask records.
    /// </summary>
    public class ProjectTaskQuery : Query<ProjectTaskQuery, ProjectTaskField, ProjectTaskView, ProjectTaskOrderField>
    {
        /// <summary>
        /// Initialize a new project task query instance.
        /// </summary>
        public ProjectTaskQuery()
            : base("projectTasks", typeof(ProjectTask), true)
        {
        }

        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        public ProjectTaskQuery SelectAssignments(ProjectTaskAssignmentQuery query)
        {
            query.FieldName = "assignments";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public ProjectTaskQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ProjectTaskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public ProjectTaskQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ProjectTaskQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Predecessors of the project task.
        /// </summary>
        public ProjectTaskQuery SelectPredecessors(ProjectTaskQuery query)
        {
            query.FieldName = "predecessors";
            return Select(query);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public ProjectTaskQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }

        /// <summary>
        /// Successors of the project task.
        /// </summary>
        public ProjectTaskQuery SelectSuccessors(ProjectTaskQuery query)
        {
            query.FieldName = "successors";
            return Select(query);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public ProjectTaskQuery SelectTimeEntries(TimeEntryQuery query)
        {
            query.FieldName = "timeEntries";
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'ProjectTask' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/projecttaskcustomfilter/">4me developer site</see>.</br>
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
        public ProjectTaskQuery CustomFilter(string name, FilterOperator filterOperator, params string[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
