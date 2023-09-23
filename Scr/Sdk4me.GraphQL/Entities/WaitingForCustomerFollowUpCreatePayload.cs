namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/waitingforcustomerfollowupcreatepayload/">WaitingForCustomerFollowUpCreatePayload</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUpCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("waitingForCustomerFollowUp"), Sdk4meField(true)]
        public WaitingForCustomerFollowUp? WaitingForCustomerFollowUp { get; internal set; }
    }
}
