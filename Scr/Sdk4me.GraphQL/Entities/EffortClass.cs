namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/effortclass/">EffortClass</see> object.
    /// </summary>
    public class EffortClass : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The amount with which to multiply the cost of time entries with this effort class.
        /// </summary>
        [JsonProperty("costMultiplier"), Sdk4meField(true)]
        public decimal? CostMultiplier { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the effort class may no longer be related to any more timesheet settings.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The name of the effort class.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the effort class takes when it is displayed in a sorted list.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(true)]
        public long? Position { get; internal set; }

        [JsonProperty("serviceOfferings")]
        internal NodeCollection<ServiceOffering>? ServiceOfferingsCollection { get; set; }

        /// <summary>
        /// Service offerings of this effort class.
        /// </summary>
        public DataList<ServiceOffering>? ServiceOfferings
        {
            get => ServiceOfferingsCollection?.Data;
        }

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

        [JsonProperty("timesheetSettings")]
        internal NodeCollection<TimesheetSetting>? TimesheetSettingsCollection { get; set; }

        /// <summary>
        /// Timesheet settings of this effort class.
        /// </summary>
        public DataList<TimesheetSetting>? TimesheetSettings
        {
            get => TimesheetSettingsCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ServiceOfferingsCollection?.GetQueryPageInfo("serviceOfferings", depth + 1));
            retval.AddRange(TimesheetSettingsCollection?.GetQueryPageInfo("timesheetSettings", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ServiceOfferings?.AddRange((data as EffortClass)?.ServiceOfferings);
            TimesheetSettings?.AddRange((data as EffortClass)?.TimesheetSettings);
        }
    }
}
