namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/reservationupdateinput/">ReservationUpdateInput</see> object.
    /// </summary>
    public class ReservationUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? configurationItemId;
        private string? createdById;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private long? duration;
        private DateTime? endAt;
        private string? id;
        private string? name;
        private string? personId;
        private DateTime? preparationStartAt;
        private ReservationRecurrenceInput? recurrence;
        private string? requestId;
        private string? reservationOfferingId;
        private string? source;
        private string? sourceID;
        private DateTime? startAt;
        private ReservationStatus? status;

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
        /// Identifier of the asset that is being reserved.
        /// </summary>
        [JsonProperty("configurationItemId")]
        public string? ConfigurationItemId
        {
            get => configurationItemId;
            set => configurationItemId = Set("configurationItemId", value);
        }

        /// <summary>
        /// Identifier of the person who created this reservation.
        /// </summary>
        [JsonProperty("createdById")]
        public string? CreatedById
        {
            get => createdById;
            set => createdById = Set("createdById", value);
        }

        /// <summary>
        /// Full description of the reservation
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [JsonProperty("descriptionAttachments")]
        public List<AttachmentInput>? DescriptionAttachments
        {
            get => descriptionAttachments;
            set => descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// The duration of the reservation during the calendar hours of the reservation offering.
        /// </summary>
        [JsonProperty("duration")]
        public long? Duration
        {
            get => duration;
            set => duration = Set("duration", value);
        }

        /// <summary>
        /// Used to specify the end date and time of the reservation.
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
        /// A short description of the reservation
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the person for whom this reservation was created.
        /// </summary>
        [JsonProperty("personId")]
        public string? PersonId
        {
            get => personId;
            set => personId = Set("personId", value);
        }

        /// <summary>
        /// The start date and time of the preparation of the asset for the reservation. Only present in case the reservation offering specifies a preparation duration.
        /// </summary>
        [JsonProperty("preparationStartAt")]
        public DateTime? PreparationStartAt
        {
            get => preparationStartAt;
            set => preparationStartAt = Set("preparationStartAt", value);
        }

        /// <summary>
        /// Recurrence for the reservation.
        /// </summary>
        [JsonProperty("recurrence")]
        public ReservationRecurrenceInput? Recurrence
        {
            get => recurrence;
            set => recurrence = Set("recurrence", value);
        }

        /// <summary>
        /// Identifier of the request for reservation.
        /// </summary>
        [JsonProperty("requestId")]
        public string? RequestId
        {
            get => requestId;
            set => requestId = Set("requestId", value);
        }

        /// <summary>
        /// Identifier of the reservation offering that was used to create this reservation.
        /// </summary>
        [JsonProperty("reservationOfferingId")]
        public string? ReservationOfferingId
        {
            get => reservationOfferingId;
            set => reservationOfferingId = Set("reservationOfferingId", value);
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
        /// Used to specify the start date and time of the reservation.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [JsonProperty("status")]
        public ReservationStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }
    }
}
