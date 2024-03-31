namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing request template.
    /// </summary>
    internal class RequestTemplateUpdateMutation : Mutation<RequestTemplateUpdatePayload, RequestTemplateUpdateInput>
    {
        /// <summary>
        /// Initialize an new RequestTemplateUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal RequestTemplateUpdateMutation(RequestTemplateUpdateInput data, RequestTemplateQuery query)
            : base("requestTemplateUpdate", "RequestTemplateUpdateInput!", data, GetQuery(query))
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
