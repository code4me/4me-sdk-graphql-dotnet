using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectrisklevelupdatepayload/">ProjectRiskLevelUpdatePayload</see> object.
    /// </summary>
    public class ProjectRiskLevelUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectRiskLevel"), Sdk4meField(true)]
        public ProjectRiskLevel? ProjectRiskLevel { get; internal set; }
    }
}
