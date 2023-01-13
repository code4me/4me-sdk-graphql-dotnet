namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving OutOfOfficePeriod records.
    /// </summary>
    public class OutOfOfficePeriodQuery : Query<OutOfOfficePeriodQuery, OutOfOfficePeriodField, OutOfOfficePeriodView, OutOfOfficePeriodOrderField>
    {
        /// <summary>
        /// Initialize a new out of office period query instance.
        /// </summary>
        public OutOfOfficePeriodQuery()
            : base("outOfOfficePeriods", typeof(OutOfOfficePeriod), true)
        {
        }
    }
}
