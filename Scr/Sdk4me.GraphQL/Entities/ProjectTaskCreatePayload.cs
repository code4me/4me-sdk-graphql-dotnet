namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttaskcreatepayload/">ProjectTaskCreatePayload</see> object.
    /// </summary>
    public class ProjectTaskCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTask"), Sdk4meField(true)]
        public ProjectTask? ProjectTask { get; internal set; }
    }
}
