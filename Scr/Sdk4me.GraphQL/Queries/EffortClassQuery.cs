namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving EffortClass records.
    /// </summary>
    public class EffortClassQuery : Query<EffortClassQuery, EffortClassField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new effort class query instance.
        /// </summary>
        public EffortClassQuery()
            : base("effortClasses", typeof(EffortClass), true)
        {
        }

        /// <summary>
        /// Service offerings of this effort class.
        /// </summary>
        public EffortClassQuery SelectServiceOfferings(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOfferings";
            return Select(query);
        }

        /// <summary>
        /// Timesheet settings of this effort class.
        /// </summary>
        public EffortClassQuery SelectTimesheetSettings(TimesheetSettingQuery query)
        {
            query.FieldName = "timesheetSettings";
            return Select(query);
        }
    }
}
