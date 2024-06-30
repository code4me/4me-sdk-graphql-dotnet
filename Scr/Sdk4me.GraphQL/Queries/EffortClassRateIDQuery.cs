namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="EffortClassRateID">EffortClassRateID</see> query.
    /// </summary>
    public class EffortClassRateIDQuery : Query<EffortClassRateIDQuery, EffortClassRateIDField, DefaultView, DefaultFilter, DefaultOrderField>
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
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public EffortClassRateIDQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
