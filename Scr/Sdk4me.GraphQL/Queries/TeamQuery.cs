using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Team records.
    /// </summary>
    public class TeamQuery : Query<TeamQuery, TeamField, TeamView, TeamOrderField>
    {
        /// <summary>
        /// Initialize a new team query instance.
        /// </summary>
        public TeamQuery()
            : base("teams", typeof(Team), true)
        {
        }

        /// <summary>
        /// Initialize a new team query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the team.</param>
        public TeamQuery(string id)
            : base("Team", id, typeof(Team), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to automatically link records to the agile board when they are assigned to the team.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who maintains the information about the configuration items that the team supports.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectConfigurationManager(PersonQuery query)
        {
            query.FieldName = "configurationManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The current team coordinator for the team. Only members of the team can be selected in this field.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectCoordinator(PersonQuery query)
        {
            query.FieldName = "coordinator";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom field query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectCustomFields(CustomFieldQuery query)
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
        public TeamQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// The manager or supervisor of the team. This person is able to maintain the information about the team. The manager of a team does not need to be a member of the team.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectManager(PersonQuery query)
        {
            query.FieldName = "manager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// People linked as a member to the team.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectMembers(PersonQuery query)
        {
            query.FieldName = "members";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// Scrum workspace used by this team to plan their work.
        /// </summary>
        /// <param name="query">The scrum workspace query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectScrumWorkspace(ScrumWorkspaceQuery query)
        {
            query.FieldName = "scrumWorkspace";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The calendar that defines the work hours during which the team is available for work on all types of assignments.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TeamQuery SelectWorkHours(CalendarQuery query)
        {
            query.FieldName = "workHours";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Team' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/teamcustomfilter/">4me developer site</see>.</br>
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
        public TeamQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
