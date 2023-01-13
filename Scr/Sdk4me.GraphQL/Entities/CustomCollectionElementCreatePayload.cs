namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/customcollectionelementcreatepayload/">CustomCollectionElementCreatePayload</see> object.
    /// </summary>
    public class CustomCollectionElementCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollectionElement"), Sdk4meField(true)]
        public CustomCollectionElement? CustomCollectionElement { get; internal set; }
    }
}
