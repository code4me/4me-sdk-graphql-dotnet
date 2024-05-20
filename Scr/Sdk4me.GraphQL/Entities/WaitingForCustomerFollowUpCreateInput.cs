using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/waitingforcustomerfollowupcreateinput/">WaitingForCustomerFollowUpCreateInput</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUpCreateInput : PropertyChangeSet
    {
        private bool? autoComplete;
        private string? clientMutationId;
        private bool? disabled;
        private string name;
        private List<WaitingForCustomerRuleInput>? newWaitingForCustomerRules;
        private string? source;
        private string? sourceID;

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
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
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
        /// The name of the waiting for customer follow-up.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
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
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpCreateInput"/> class without providing the required values.
        /// </summary>
        public WaitingForCustomerFollowUpCreateInput()
        {
            name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpCreateInput"/> class.
        /// </summary>
        /// <param name="name">The name of the waiting for customer follow-up.</param>
        public WaitingForCustomerFollowUpCreateInput(string name)
        {
            this.name = Set("name", name);
        }
    }
}
