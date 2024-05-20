using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectupdatepayload/">ProjectUpdatePayload</see> object.
    /// </summary>
    public class ProjectUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("project"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Project? Project { get; internal set; }
    }
}
