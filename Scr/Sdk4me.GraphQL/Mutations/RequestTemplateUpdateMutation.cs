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
        internal RequestTemplateUpdateMutation(RequestTemplateUpdateInput data)
            : base("requestTemplateUpdate", "RequestTemplateUpdateInput!", data, new HashSet<IQuery>() { new RequestTemplateQuery() { FieldName = "requestTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
