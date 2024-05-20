using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/tasktemplatecreatepayload/">TaskTemplateCreatePayload</see> object.
    /// </summary>
    public class TaskTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("taskTemplate"), Sdk4meField(IsDefaultQueryProperty = true)]
        public TaskTemplate? TaskTemplate { get; internal set; }
    }
}
