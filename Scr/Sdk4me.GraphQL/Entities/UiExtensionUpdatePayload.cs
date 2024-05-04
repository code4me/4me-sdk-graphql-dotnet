using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/uiextensionupdatepayload/">UiExtensionUpdatePayload</see> object.
    /// </summary>
    public class UiExtensionUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("uiExtension"), Sdk4meField(true)]
        public UiExtension? UiExtension { get; internal set; }
    }
}
