using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowtypecreatepayload/">WorkflowTypeCreatePayload</see> object.
    /// </summary>
    public class WorkflowTypeCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("workflowType"), Sdk4meField(true)]
        public WorkflowType? WorkflowType { get; internal set; }
    }
}
