namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/holidaycreateinput/">HolidayCreateInput</see> object.
    /// </summary>
    public class HolidayCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? pictureUri;
        private List<string>? calendarIds;
        private string? clientMutationId;
        private string? name;
        private DateTime? startAt;
        private DateTime? endAt;

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
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Identifiers of calendars of the holiday.
        /// </summary>
        [JsonProperty("calendarIds")]
        public List<string>? CalendarIds
        {
            get => calendarIds;
            set => calendarIds = Set("calendarIds", value);
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
        /// Name of the holiday.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Start of the holiday.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// End of the holiday.
        /// </summary>
        [JsonProperty("endAt")]
        public DateTime? EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }
    }
}
