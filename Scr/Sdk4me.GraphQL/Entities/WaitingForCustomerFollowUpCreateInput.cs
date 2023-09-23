namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/waitingforcustomerfollowupcreateinput/">WaitingForCustomerFollowUpCreateInput</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUpCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private bool? disabled;
        private bool? autoComplete;
        private List<WaitingForCustomerRuleInput>? newWaitingForCustomerRules;
        private string? clientMutationId;
        private string? name;

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Whether the waiting for customer follow-up may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Auto-complete when the final waiting for customer notification is sent.
        /// </summary>
        [JsonProperty("autoComplete")]
        public bool? AutoComplete
        {
            get => autoComplete;
            set => autoComplete = Set("autoComplete", value);
        }

        /// <summary>
        /// Rules of this waiting for customer follow-up.
        /// </summary>
        [JsonProperty("newWaitingForCustomerRules")]
        public List<WaitingForCustomerRuleInput>? NewWaitingForCustomerRules
        {
            get => newWaitingForCustomerRules;
            set => newWaitingForCustomerRules = Set("newWaitingForCustomerRules", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The name of the waiting for customer follow-up.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }
    }
}
