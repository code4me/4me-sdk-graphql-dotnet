namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/translationupdatepayload/">TranslationUpdatePayload</see> object.
    /// </summary>
    public class TranslationUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("translation"), Sdk4meField(true)]
        public Translation? Translation { get; internal set; }
    }
}
