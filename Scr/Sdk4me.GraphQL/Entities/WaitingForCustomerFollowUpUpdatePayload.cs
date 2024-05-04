using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/waitingforcustomerfollowupupdatepayload/">WaitingForCustomerFollowUpUpdatePayload</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUpUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("waitingForCustomerFollowUp"), Sdk4meField(true)]
        public WaitingForCustomerFollowUp? WaitingForCustomerFollowUp { get; internal set; }
    }
}
