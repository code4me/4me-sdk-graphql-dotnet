namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new request template.
    /// </summary>
    internal class RequestTemplateCreateMutation : Mutation<RequestTemplateCreatePayload, RequestTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new RequestTemplateCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal RequestTemplateCreateMutation(RequestTemplateCreateInput data, RequestTemplateQuery query)
            : base("requestTemplateCreate", "RequestTemplateCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(RequestTemplateQuery query)
        {
            query.FieldName = "requestTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
