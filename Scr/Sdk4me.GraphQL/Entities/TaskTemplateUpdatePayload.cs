using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/tasktemplateupdatepayload/">TaskTemplateUpdatePayload</see> object.
    /// </summary>
    public class TaskTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("taskTemplate"), Sdk4meField(true)]
        public TaskTemplate? TaskTemplate { get; internal set; }
    }
}
