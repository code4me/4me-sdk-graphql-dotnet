namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/holiday/">Holiday</see> object.
    /// </summary>
    public class Holiday : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("calendars")]
        internal NodeCollection<Calendar>? CalendarsCollection { get; set; }

        /// <summary>
        /// Calendars of the holiday.
        /// </summary>
        public DataList<Calendar>? Calendars
        {
            get => CalendarsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// End of the holiday.
        /// </summary>
        [JsonProperty("endAt"), Sdk4meField(true)]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// Name of the holiday.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// Start of the holiday.
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(true)]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CalendarsCollection?.GetQueryPageInfo("calendars", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Calendars?.AddRange((data as Holiday)?.Calendars);
        }
    }
}
