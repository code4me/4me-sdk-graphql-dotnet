using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttemplatecreatepayload/">ProjectTemplateCreatePayload</see> object.
    /// </summary>
    public class ProjectTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTemplate"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ProjectTemplate? ProjectTemplate { get; internal set; }
    }
}
