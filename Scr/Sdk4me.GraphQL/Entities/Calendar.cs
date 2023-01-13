namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/calendar/">Calendar</see> object.
    /// </summary>
    public class Calendar : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("calendarHours")]
        internal NodeCollection<CalendarHour>? CalendarHoursCollection { get; set; }

        /// <summary>
        /// Calendar hours of the calendar.
        /// </summary>
        public DataList<CalendarHour>? CalendarHours
        {
            get => CalendarHoursCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the calendar may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        [JsonProperty("holidays")]
        internal NodeCollection<Holiday>? HolidaysCollection { get; set; }

        /// <summary>
        /// Holidays of the calendar.
        /// </summary>
        public DataList<Holiday>? Holidays
        {
            get => HolidaysCollection?.Data;
        }

        /// <summary>
        /// The name of the calendar.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

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
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CalendarHoursCollection?.GetQueryPageInfo("calendarHours", depth + 1));
            retval.AddRange(HolidaysCollection?.GetQueryPageInfo("holidays", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CalendarHours?.AddRange((data as Calendar)?.CalendarHours);
            Holidays?.AddRange((data as Calendar)?.Holidays);
        }
    }
}
