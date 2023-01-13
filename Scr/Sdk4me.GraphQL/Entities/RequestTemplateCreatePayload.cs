namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/requesttemplatecreatepayload/">RequestTemplateCreatePayload</see> object.
    /// </summary>
    public class RequestTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("requestTemplate"), Sdk4meField(true)]
        public RequestTemplate? RequestTemplate { get; internal set; }
    }
}
