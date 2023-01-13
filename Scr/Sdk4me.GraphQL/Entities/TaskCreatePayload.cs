namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/taskcreatepayload/">TaskCreatePayload</see> object.
    /// </summary>
    public class TaskCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("task"), Sdk4meField(true)]
        public Task? Task { get; internal set; }
    }
}
