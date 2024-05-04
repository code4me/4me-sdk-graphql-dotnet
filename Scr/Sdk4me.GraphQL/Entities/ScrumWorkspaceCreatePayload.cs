using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/scrumworkspacecreatepayload/">ScrumWorkspaceCreatePayload</see> object.
    /// </summary>
    public class ScrumWorkspaceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("scrumWorkspace"), Sdk4meField(true)]
        public ScrumWorkspace? ScrumWorkspace { get; internal set; }
    }
}
