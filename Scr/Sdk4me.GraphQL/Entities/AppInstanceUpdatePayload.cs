namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appinstanceupdatepayload/">AppInstanceUpdatePayload</see> object.
    /// </summary>
    public class AppInstanceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appInstance"), Sdk4meField(true)]
        public AppInstance? AppInstance { get; internal set; }
    }
}
