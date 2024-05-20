using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttasktemplatecreatepayload/">ProjectTaskTemplateCreatePayload</see> object.
    /// </summary>
    public class ProjectTaskTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTaskTemplate"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ProjectTaskTemplate? ProjectTaskTemplate { get; internal set; }
    }
}
