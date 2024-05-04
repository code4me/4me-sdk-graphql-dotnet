using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttasktemplateupdatepayload/">ProjectTaskTemplateUpdatePayload</see> object.
    /// </summary>
    public class ProjectTaskTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTaskTemplate"), Sdk4meField(true)]
        public ProjectTaskTemplate? ProjectTaskTemplate { get; internal set; }
    }
}
