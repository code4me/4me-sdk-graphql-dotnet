namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing timesheet setting.
    /// </summary>
    internal class TimesheetSettingUpdateMutation : Mutation<TimesheetSettingUpdatePayload, TimesheetSettingUpdateInput>
    {
        /// <summary>
        /// Initialize an new TimesheetSettingUpdate mutation instance.
        /// </summary>
        internal TimesheetSettingUpdateMutation(TimesheetSettingUpdateInput data)
            : base("timesheetSettingUpdate", "TimesheetSettingUpdateInput!", data, new HashSet<IQuery>() { new TimesheetSettingQuery() { FieldName = "timesheetSetting", IsConnection = false }.Select("*") })
        {
        }
    }
}
