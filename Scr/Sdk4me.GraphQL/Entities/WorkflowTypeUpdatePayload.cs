using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowtypeupdatepayload/">WorkflowTypeUpdatePayload</see> object.
    /// </summary>
    public class WorkflowTypeUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflowType"), Sdk4meField(true)]
        public WorkflowType? WorkflowType { get; internal set; }
    }
}
