using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectcreatepayload/">ProjectCreatePayload</see> object.
    /// </summary>
    public class ProjectCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("project"), Sdk4meField(true)]
        public Project? Project { get; internal set; }
    }
}
