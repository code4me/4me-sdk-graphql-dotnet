using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/recurrence/">Recurrence</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class Recurrence : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString();
        }

        /// <summary>
        /// <br>_Required_ when `frequency` is `daily`, ignored in all other cases. List of days of the week, e.g. `1,2,3,4,5`.</br>
        /// <br>- * `0`: Sunday</br>
        /// <br>- * `1`: Monday</br>
        /// <br>- * `2`: Tuesday</br>
        /// <br>- * `3`: Wednesday</br>
        /// <br>- * `4`: Thursday</br>
        /// <br>- * `5`: Friday</br>
        /// <br>- * `6`: Saturday</br>.
        /// </summary>
        [JsonProperty("day"), Sdk4meField(true)]
        public List<long>? Day { get; internal set; }

        /// <summary>
        /// <br>_Required_ when `frequency` is `monthly` and `day_of_week` is `false`, ignored in all other cases. List of days of the month, e.g. `11,21,-1`.</br>
        /// <br>- * `1`: Day one</br>
        /// <br>- * `2`: Day two</br>
        /// <br>- * `3`: Day three</br>
        /// <br>- * ...</br>
        /// <br>- * `30`: Day thirty</br>
        /// <br>- * `31`: Day thirty-one</br>
        /// <br>- * `-1`: Last day of month</br>.
        /// </summary>
        [JsonProperty("dayOfMonth"), Sdk4meField(true)]
        public List<long>? DayOfMonth { get; internal set; }

        /// <summary>
        /// Indicates whether or not the `dayOfWeekIndex` and `dayOfWeekDay` values should be considered. Can only be set to `true` when `frequency` is `monthly` or `yearly`.
        /// </summary>
        [JsonProperty("dayOfWeek"), Sdk4meField(true)]
        public bool? DayOfWeek { get; internal set; }

        /// <summary>
        /// _Required_ when `dayOfWeek` is `true`, ignored in all other cases. list of days of the week.
        /// </summary>
        [JsonProperty("dayOfWeekDay"), Sdk4meField(true)]
        public List<DayNames>? DayOfWeekDay { get; internal set; }

        /// <summary>
        /// _Required_ when `dayOfWeek` is `true`, ignored in all other cases.
        /// </summary>
        [JsonProperty("dayOfWeekIndex"), Sdk4meField(true)]
        public RecurrenceDayOfWeekIndex? DayOfWeekIndex { get; internal set; }

        /// <summary>
        /// Whether recurrency should be temporarily disabled.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The date at which to end the Recurrence.
        /// </summary>
        [JsonProperty("endDate"), Sdk4meField(true)]
        public DateOnly? EndDate { get; internal set; }

        /// <summary>
        /// The frequency of the recurrency.
        /// </summary>
        [JsonProperty("frequency"), Sdk4meField(true)]
        public RecurrenceFrequency? Frequency { get; internal set; }

        /// <summary>
        /// The ICAL representation of the recurrency (without time_of_day).
        /// </summary>
        [JsonProperty("ical")]
        public string? Ical { get; internal set; }

        /// <summary>
        /// The interval of the Frequency, e.g. every 2nd week or every 10th day.
        /// </summary>
        [JsonProperty("interval"), Sdk4meField(true)]
        public long? Interval { get; internal set; }

        /// <summary>
        /// The time and date at which the last occurrence was created.
        /// </summary>
        [JsonProperty("lastOccurrenceAt"), Sdk4meField(true)]
        public DateTime? LastOccurrenceAt { get; internal set; }

        /// <summary>
        /// The validation errors during the last occurrence that prevented the record from being created.
        /// </summary>
        [JsonProperty("lastOccurrenceErrors"), Sdk4meField(true)]
        public string? LastOccurrenceErrors { get; internal set; }

        /// <summary>
        /// <br>_Required_ when `frequency` is `yearly`, ignored in all other cases. List of months of the year, e.g. `3,6,9,12`.</br>
        /// <br>- * `1`: January</br>
        /// <br>- * `2`: February</br>
        /// <br>- * `3`: March</br>
        /// <br>- * `4`: April</br>
        /// <br>- * `5`: May</br>
        /// <br>- * `6`: June</br>
        /// <br>- * `7`: July</br>
        /// <br>- * `8`: August</br>
        /// <br>- * `9`: September</br>
        /// <br>- * `10`: October</br>
        /// <br>- * `11`: November</br>
        /// <br>- * `12`: December</br>.
        /// </summary>
        [JsonProperty("monthOfYear"), Sdk4meField(true)]
        public List<long>? MonthOfYear { get; internal set; }

        /// <summary>
        /// The time and date at which the next occurrence will be created.
        /// </summary>
        [JsonProperty("nextOccurrenceAt"), Sdk4meField(true)]
        public DateTime? NextOccurrenceAt { get; internal set; }

        /// <summary>
        /// The date at which to start the Recurrence.
        /// </summary>
        [JsonProperty("startDate"), Sdk4meField(true)]
        public DateOnly? StartDate { get; internal set; }

        /// <summary>
        /// The time of day to start the scheduled occurrence.
        /// </summary>
        [JsonProperty("timeOfDay"), Sdk4meField(true)]
        public TimeSpan? TimeOfDay { get; internal set; }

        /// <summary>
        /// <br>The time zone for the `timeOfDay` field.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see></br>.
        /// </summary>
        [JsonProperty("timeZone"), Sdk4meField(true)]
        public string? TimeZone { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
