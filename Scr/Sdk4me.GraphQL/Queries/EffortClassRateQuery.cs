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

        /// <summary>
        /// The effort class of the effort class rate.
        /// </summary>
        public EffortClassRateQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service offering of the effort class rate.
        /// </summary>
        public EffortClassRateQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOffering";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
