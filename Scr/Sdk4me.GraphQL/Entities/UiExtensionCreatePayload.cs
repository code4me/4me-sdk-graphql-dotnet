namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/uiextensioncreatepayload/">UiExtensionCreatePayload</see> object.
    /// </summary>
    public class UiExtensionCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("uiExtension"), Sdk4meField(true)]
        public UiExtension? UiExtension { get; internal set; }
    }
}
