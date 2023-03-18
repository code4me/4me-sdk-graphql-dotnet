namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassRate">EffortClassRate</see> query.
    /// </summary>
    public class EffortClassRateQuery : Query<EffortClassRateQuery, EffortClassRateField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new effort class rate query instance.
        /// </summary>
        public EffortClassRateQuery()
            : base("", typeof(EffortClassRate), true)
        {
        }
    }
}
