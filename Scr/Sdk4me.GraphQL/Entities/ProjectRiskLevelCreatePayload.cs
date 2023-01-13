namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projectrisklevelcreatepayload/">ProjectRiskLevelCreatePayload</see> object.
    /// </summary>
    public class ProjectRiskLevelCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectRiskLevel"), Sdk4meField(true)]
        public ProjectRiskLevel? ProjectRiskLevel { get; internal set; }
    }
}
