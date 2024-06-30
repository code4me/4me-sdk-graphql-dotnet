namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TimesheetSetting records.
    /// </summary>
    public class TimesheetSettingQuery : Query<TimesheetSettingQuery, TimesheetSettingField, DefaultView, TimesheetSettingFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new timesheet setting query instance.
        /// </summary>
        public TimesheetSettingQuery()
            : base("timesheetSettings", typeof(TimesheetSetting), true)
        {
        }

        /// <summary>
        /// Initialize a new timesheet setting query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the timesheet setting.</param>
        public TimesheetSettingQuery(string id)
            : base("TimesheetSetting", id, typeof(TimesheetSetting), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Effort classes of the timesheet setting.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectEffortClasses(EffortClassQuery query)
        {
            query.FieldName = "effortClasses";
            return Select(query);
        }

        /// <summary>
        /// Organizations of the timesheet setting.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a problem.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectProblemEffortClass(EffortClassQuery query)
        {
            query.FieldName = "problemEffortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a project task.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectProjectTaskEffortClass(EffortClassQuery query)
        {
            query.FieldName = "projectTaskEffortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a request.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectRequestEffortClass(EffortClassQuery query)
        {
            query.FieldName = "requestEffortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a workflow task.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectTaskEffortClass(EffortClassQuery query)
        {
            query.FieldName = "taskEffortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that is selected by default, when someone in an organization linked to the timesheet settings registers time on a time allocation.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimesheetSettingQuery SelectTimeAllocationEffortClass(EffortClassQuery query)
        {
            query.FieldName = "timeAllocationEffortClass";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
