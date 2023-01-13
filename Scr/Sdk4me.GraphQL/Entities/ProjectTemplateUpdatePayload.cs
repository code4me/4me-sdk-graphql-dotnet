namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttemplateupdatepayload/">ProjectTemplateUpdatePayload</see> object.
    /// </summary>
    public class ProjectTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectTemplate"), Sdk4meField(true)]
        public ProjectTemplate? ProjectTemplate { get; internal set; }
    }
}
