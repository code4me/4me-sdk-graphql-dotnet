namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TimesheetSetting records.
    /// </summary>
    public class TimesheetSettingQuery : Query<TimesheetSettingQuery, TimesheetSettingField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new timesheet setting query instance.
        /// </summary>
        public TimesheetSettingQuery()
            : base("timesheetSettings", typeof(TimesheetSetting), true)
        {
        }

        /// <summary>
        /// Effort classes of the timesheet setting.
        /// </summary>
        public TimesheetSettingQuery SelectEffortClasses(EffortClassQuery query)
        {
            query.FieldName = "effortClasses";
            return Select(query);
        }

        /// <summary>
        /// Organizations of the timesheet setting.
        /// </summary>
        public TimesheetSettingQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }
    }
}
