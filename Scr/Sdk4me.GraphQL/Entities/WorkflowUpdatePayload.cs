using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowupdatepayload/">WorkflowUpdatePayload</see> object.
    /// </summary>
    public class WorkflowUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflow"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Workflow? Workflow { get; internal set; }
    }
}
