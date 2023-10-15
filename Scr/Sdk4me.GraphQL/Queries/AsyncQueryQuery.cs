namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AsyncQuery">AsyncQuery</see> query.
    /// </summary>
    public class AsyncQueryQuery : Query<AsyncQueryQuery, AsyncQueryField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new async query query instance.
        /// </summary>
        public AsyncQueryQuery()
            : base("", typeof(AsyncQuery), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public AsyncQueryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person or application who created the async query.
        /// </summary>
        public AsyncQueryQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
