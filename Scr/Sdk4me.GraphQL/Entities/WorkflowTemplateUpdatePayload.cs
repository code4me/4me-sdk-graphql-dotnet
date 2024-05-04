using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowtemplateupdatepayload/">WorkflowTemplateUpdatePayload</see> object.
    /// </summary>
    public class WorkflowTemplateUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflowTemplate"), Sdk4meField(true)]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }
    }
}
