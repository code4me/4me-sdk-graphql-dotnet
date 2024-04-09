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
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EffortClassRateQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service offering of the effort class rate.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EffortClassRateQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOffering";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
