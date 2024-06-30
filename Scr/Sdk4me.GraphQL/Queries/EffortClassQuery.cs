namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving EffortClass records.
    /// </summary>
    public class EffortClassQuery : Query<EffortClassQuery, EffortClassField, DefaultView, EffortClassFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new effort class query instance.
        /// </summary>
        public EffortClassQuery()
            : base("effortClasses", typeof(EffortClass), true)
        {
        }

        /// <summary>
        /// Initialize a new effort class query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the effort class.</param>
        public EffortClassQuery(string id)
            : base("EffortClass", id, typeof(EffortClass), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EffortClassQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service offerings of this effort class.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EffortClassQuery SelectServiceOfferings(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOfferings";
            return Select(query);
        }

        /// <summary>
        /// Skill pools of this effort class.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EffortClassQuery SelectSkillPools(SkillPoolQuery query)
        {
            query.FieldName = "skillPools";
            return Select(query);
        }

        /// <summary>
        /// Timesheet settings of this effort class.
        /// </summary>
        /// <param name="query">The timesheet setting query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EffortClassQuery SelectTimesheetSettings(TimesheetSettingQuery query)
        {
            query.FieldName = "timesheetSettings";
            return Select(query);
        }
    }
}
