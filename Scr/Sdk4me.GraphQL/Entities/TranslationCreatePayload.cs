using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/translationcreatepayload/">TranslationCreatePayload</see> object.
    /// </summary>
    public class TranslationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("translation"), Sdk4meField(true)]
        public Translation? Translation { get; internal set; }
    }
}
