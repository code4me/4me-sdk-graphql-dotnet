namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Period">Period</see> query.
    /// </summary>
    public class PeriodQuery : Query<PeriodQuery, PeriodField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new period query instance.
        /// </summary>
        public PeriodQuery()
            : base("", typeof(Period), false)
        {
        }
    }
}
