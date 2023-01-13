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
        internal RequestUpdateMutation(RequestUpdateInput data)
            : base("requestUpdate", "RequestUpdateInput!", data, new HashSet<IQuery>() { new RequestQuery() { FieldName = "request", IsConnection = false }.Select("*") })
        {
        }
    }
}
