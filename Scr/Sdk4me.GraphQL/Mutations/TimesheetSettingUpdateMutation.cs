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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal TimesheetSettingUpdateMutation(TimesheetSettingUpdateInput data, TimesheetSettingQuery query)
            : base("timesheetSettingUpdate", "TimesheetSettingUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TimesheetSettingQuery query)
        {
            query.FieldName = "timesheetSetting";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
