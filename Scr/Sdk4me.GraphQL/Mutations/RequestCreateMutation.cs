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
        internal RequestCreateMutation(RequestCreateInput data)
            : base("requestCreate", "RequestCreateInput!", data, new HashSet<IQuery>() { new RequestQuery() { FieldName = "request", IsConnection = false }.Select("*") })
        {
        }
    }
}
