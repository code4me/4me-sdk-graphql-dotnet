namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new request.
    /// </summary>
    internal class RequestCreateMutation : Mutation<RequestCreatePayload, RequestCreateInput>
    {
        /// <summary>
        /// Initialize an new RequestCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal RequestCreateMutation(RequestCreateInput data, RequestQuery query)
            : base("requestCreate", "RequestCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(RequestQuery query)
        {
            query.FieldName = "request";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
