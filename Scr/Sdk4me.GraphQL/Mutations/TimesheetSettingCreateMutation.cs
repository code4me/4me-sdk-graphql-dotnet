namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new timesheet setting.
    /// </summary>
    internal class TimesheetSettingCreateMutation : Mutation<TimesheetSettingCreatePayload, TimesheetSettingCreateInput>
    {
        /// <summary>
        /// Initialize an new TimesheetSettingCreate mutation instance.
        /// </summary>
        internal TimesheetSettingCreateMutation(TimesheetSettingCreateInput data)
            : base("timesheetSettingCreate", "TimesheetSettingCreateInput!", data, new HashSet<IQuery>() { new TimesheetSettingQuery() { FieldName = "timesheetSetting", IsConnection = false }.Select("*") })
        {
        }
    }
}
