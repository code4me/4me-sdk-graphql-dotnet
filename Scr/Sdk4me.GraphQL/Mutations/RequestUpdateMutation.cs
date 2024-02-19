namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing request.
    /// </summary>
    internal class RequestUpdateMutation : Mutation<RequestUpdatePayload, RequestUpdateInput>
    {
        /// <summary>
        /// Initialize an new RequestUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal RequestUpdateMutation(RequestUpdateInput data, RequestQuery query)
            : base("requestUpdate", "RequestUpdateInput!", data, GetQuery(query))
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
