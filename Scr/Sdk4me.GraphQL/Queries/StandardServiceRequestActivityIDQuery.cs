namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="StandardServiceRequestActivityID">StandardServiceRequestActivityID</see> query.
    /// </summary>
    public class StandardServiceRequestActivityIDQuery : Query<StandardServiceRequestActivityIDQuery, StandardServiceRequestActivityIDField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new standard service request activity identifier query instance.
        /// </summary>
        public StandardServiceRequestActivityIDQuery()
            : base("", typeof(StandardServiceRequestActivityID), true)
        {
        }
    }
}
