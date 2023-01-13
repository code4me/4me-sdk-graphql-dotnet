namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/effortclasscreatepayload/">EffortClassCreatePayload</see> object.
    /// </summary>
    public class EffortClassCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("effortClass"), Sdk4meField(true)]
        public EffortClass? EffortClass { get; internal set; }
    }
}
