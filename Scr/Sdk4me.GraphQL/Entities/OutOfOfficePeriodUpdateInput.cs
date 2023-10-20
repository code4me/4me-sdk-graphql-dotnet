namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/outofofficeperiodupdateinput/">OutOfOfficePeriodUpdateInput</see> object.
    /// </summary>
    public class OutOfOfficePeriodUpdateInput : PropertyChangeSet
    {
        private string? approvalDelegateId;
        private string? clientMutationId;
        private DateTime? endAt;
        private string? id;
        private string? personId;
        private string? reason;
        private string? source;
        private string? sourceID;
        private DateTime? startAt;
        private string? timeAllocationId;

        /// <summary>
        /// Identifier of the person who is selected as the approval delegate for the out of office period.
        /// </summary>
        [JsonProperty("approvalDelegateId")]
        public string? ApprovalDelegateId
        {
            get => approvalDelegateId;
            set => approvalDelegateId = Set("approvalDelegateId", value);
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
        /// End time of the out of office period.
        /// </summary>
        [JsonProperty("endAt")]
        public DateTime? EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifier of the person who is out of office.
        /// </summary>
        [JsonProperty("personId")]
        public string? PersonId
        {
            get => personId;
            set => personId = Set("personId", value);
        }

        /// <summary>
        /// The reason of the out of office period. Required when the description category of the time allocation is required.
        /// </summary>
        [JsonProperty("reason")]
        public string? Reason
        {
            get => reason;
            set => reason = Set("reason", value);
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
        /// Start time of the out of office period.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// Used to generate time entries for the out of office period. Only the time allocations without service and customer that are linked to the person's organization can be selected. This field is required if at least one time allocation exists that meets those conditions.
        /// </summary>
        [JsonProperty("timeAllocationId")]
        public string? TimeAllocationId
        {
            get => timeAllocationId;
            set => timeAllocationId = Set("timeAllocationId", value);
        }
    }
}
