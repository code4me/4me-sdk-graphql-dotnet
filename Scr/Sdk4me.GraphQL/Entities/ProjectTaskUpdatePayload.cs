using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttaskupdatepayload/">ProjectTaskUpdatePayload</see> object.
    /// </summary>
    public class ProjectTaskUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTask"), Sdk4meField(true)]
        public ProjectTask? ProjectTask { get; internal set; }
    }
}
