using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/waitingforcustomerfollowupupdateinput/">WaitingForCustomerFollowUpUpdateInput</see> object.
    /// </summary>
    public class WaitingForCustomerFollowUpUpdateInput : PropertyChangeSet
    {
        private bool? autoComplete;
        private string? clientMutationId;
        private bool? disabled;
        private string id;
        private string? name;
        private List<WaitingForCustomerRuleInput>? newWaitingForCustomerRules;
        private string? source;
        private string? sourceID;
        private List<string>? waitingForCustomerRulesToDelete;

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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
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
        /// Identifiers of rules to remove from the waiting for customer follow-up.
        /// </summary>
        [JsonProperty("waitingForCustomerRulesToDelete")]
        public List<string>? WaitingForCustomerRulesToDelete
        {
            get => waitingForCustomerRulesToDelete;
            set => waitingForCustomerRulesToDelete = Set("waitingForCustomerRulesToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpUpdateInput"/> class without providing the required values.
        /// </summary>
        public WaitingForCustomerFollowUpUpdateInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public WaitingForCustomerFollowUpUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
