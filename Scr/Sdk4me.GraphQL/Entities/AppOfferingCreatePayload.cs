namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appofferingcreatepayload/">AppOfferingCreatePayload</see> object.
    /// </summary>
    public class AppOfferingCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appOffering"), Sdk4meField(true)]
        public AppOffering? AppOffering { get; internal set; }
    }
}
