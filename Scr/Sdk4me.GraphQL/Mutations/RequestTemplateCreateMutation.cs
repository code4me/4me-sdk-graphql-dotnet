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
        internal RequestTemplateCreateMutation(RequestTemplateCreateInput data)
            : base("requestTemplateCreate", "RequestTemplateCreateInput!", data, new HashSet<IQuery>() { new RequestTemplateQuery() { FieldName = "requestTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
