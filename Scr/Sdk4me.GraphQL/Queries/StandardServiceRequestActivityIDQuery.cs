namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequestActivityID">StandardServiceRequestActivityID</see> query.
    /// </summary>
    public class StandardServiceRequestActivityIDQuery : Query<StandardServiceRequestActivityIDQuery, StandardServiceRequestActivityIDField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new standard service request activity id query instance.
        /// </summary>
        public StandardServiceRequestActivityIDQuery()
            : base("", typeof(StandardServiceRequestActivityID), true)
        {
        }

        /// <summary>
        /// The standard service request for which an activityID is provided.
        /// </summary>
        /// <param name="query">The standard service request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public StandardServiceRequestActivityIDQuery SelectStandardServiceRequest(StandardServiceRequestQuery query)
        {
            query.FieldName = "standardServiceRequest";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
