using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProjectTask records.
    /// </summary>
    public class ProjectTaskQuery : Query<ProjectTaskQuery, ProjectTaskField, ProjectTaskView, ProjectTaskFilter, ProjectTaskOrderField>
    {
        /// <summary>
        /// Initialize a new project task query instance.
        /// </summary>
        public ProjectTaskQuery()
            : base("projectTasks", typeof(ProjectTask), true)
        {
        }

        /// <summary>
        /// Initialize a new project task query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the project task.</param>
        public ProjectTaskQuery(string id)
            : base("ProjectTask", id, typeof(ProjectTask), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            query.FieldName = "agileBoardColumn";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        /// <param name="query">The project task assignment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectAssignments(ProjectTaskAssignmentQuery query)
        {
            query.FieldName = "assignments";
            return Select(query);
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        /// <param name="query">The automation rule query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom field query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        /// <param name="query">The note query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// The PDF design associated with the task.
        /// </summary>
        /// <param name="query">The pdf design query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectPdfDesign(PdfDesignQuery query)
        {
            query.FieldName = "pdfDesign";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The phase of the project to which the project task belongs.
        /// </summary>
        /// <param name="query">The project phase query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectPhase(ProjectPhaseQuery query)
        {
            query.FieldName = "phase";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Predecessors of the project task.
        /// </summary>
        /// <param name="query">The project task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectPredecessors(ProjectTaskQuery query)
        {
            query.FieldName = "predecessors";
            return Select(query);
        }

        /// <summary>
        /// The project to which the project task belongs.
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectProject(ProjectQuery query)
        {
            query.FieldName = "project";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Skill pool that represents the specific expertise needed to complete the task.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectSkillPool(SkillPoolQuery query)
        {
            query.FieldName = "skillPool";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        /// <param name="query">The sprint backlog item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }

        /// <summary>
        /// Successors of the project task.
        /// </summary>
        /// <param name="query">The project task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectSuccessors(ProjectTaskQuery query)
        {
            query.FieldName = "successors";
            return Select(query);
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the project task.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The team to which the project task is to be assigned.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The project task template that was used to register the project task.
        /// </summary>
        /// <param name="query">The project task template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProjectTaskQuery SelectTemplate(ProjectTaskTemplateQuery query)
        {
            query.FieldName = "template";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        /// <param name="query">The time entry query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
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
        public ProjectTaskQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
