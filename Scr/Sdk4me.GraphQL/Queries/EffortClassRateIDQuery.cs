namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassRateID">EffortClassRateID</see> query.
    /// </summary>
    public class EffortClassRateIDQuery : Query<EffortClassRateIDQuery, EffortClassRateIDField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new effort class rate id query instance.
        /// </summary>
        public EffortClassRateIDQuery()
            : base("", typeof(EffortClassRateID), true)
        {
        }

        /// <summary>
        /// The effort class for which a rateID is provided.
        /// </summary>
        public EffortClassRateIDQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
