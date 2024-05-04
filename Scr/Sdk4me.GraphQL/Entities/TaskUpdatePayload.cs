using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/taskupdatepayload/">TaskUpdatePayload</see> object.
    /// </summary>
    public class TaskUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("task"), Sdk4meField(true)]
        public Task? Task { get; internal set; }
    }
}
