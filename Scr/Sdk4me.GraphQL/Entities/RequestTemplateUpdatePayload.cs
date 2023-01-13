namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/requesttemplateupdatepayload/">RequestTemplateUpdatePayload</see> object.
    /// </summary>
    public class RequestTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("requestTemplate"), Sdk4meField(true)]
        public RequestTemplate? RequestTemplate { get; internal set; }
    }
}
