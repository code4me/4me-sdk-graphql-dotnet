namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequest">StandardServiceRequest</see> query.
    /// </summary>
    public class StandardServiceRequestQuery : Query<StandardServiceRequestQuery, StandardServiceRequestField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new standard service request query instance.
        /// </summary>
        public StandardServiceRequestQuery()
            : base("", typeof(StandardServiceRequest), true)
        {
        }
    }
}
