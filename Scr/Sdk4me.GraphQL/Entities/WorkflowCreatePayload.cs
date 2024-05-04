using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowcreatepayload/">WorkflowCreatePayload</see> object.
    /// </summary>
    public class WorkflowCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflow"), Sdk4meField(true)]
        public Workflow? Workflow { get; internal set; }
    }
}
