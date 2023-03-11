using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/recurrencetemplate/">RecurrenceTemplate</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class RecurrenceTemplate : Node
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
        /// Select a calendar to skip occurrences of the recurrence during off-hours and holidays.
        /// </summary>
        [JsonProperty("calendar")]
        public Calendar? Calendar { get; internal set; }

        /// <summary>
        /// <br>_Required_ when `frequency` is `daily`, ignored in all other cases. List of days of the week, e.g. `1,2,3,4,5`.</br>
        /// <br>- `0`: Sunday</br>
        /// <br>- `1`: Monday</br>
        /// <br>- `2`: Tuesday</br>
        /// <br>- `3`: Wednesday</br>
        /// <br>- `4`: Thursday</br>
        /// <br>- `5`: Friday</br>
        /// <br>- `6`: Saturday</br>.
        /// </summary>
        [JsonProperty("day")]
        public List<long>? Day { get; internal set; }

        /// <summary>
        /// <br>_Required_ when `frequency` is `monthly` and `day_of_week` is `false`, ignored in all other cases. List of days of the month, e.g. `11,21,-1`.</br>
        /// <br>- `1`: Day one</br>
        /// <br>- `2`: Day two</br>
        /// <br>- `3`: Day three</br>
        /// <br>- ...</br>
        /// <br>- `30`: Day thirty</br>
        /// <br>- `31`: Day thirty-one</br>
        /// <br>- `-1`: Last day of month</br>.
        /// </summary>
        [JsonProperty("dayOfMonth")]
        public List<long>? DayOfMonth { get; internal set; }

        /// <summary>
        /// Indicates whether or not the `dayOfWeekIndex` and `dayOfWeekDay` values should be considered. Can only be set to `true` when `frequency` is `monthly` or `yearly`.
        /// </summary>
        [JsonProperty("dayOfWeek")]
        public bool? DayOfWeek { get; internal set; }

        /// <summary>
        /// _Required_ when `dayOfWeek` is `true`, ignored in all other cases. list of days of the week.
        /// </summary>
        [JsonProperty("dayOfWeekDay")]
        public List<DayNames>? DayOfWeekDay { get; internal set; }

        /// <summary>
        /// _Required_ when `dayOfWeek` is `true`, ignored in all other cases.
        /// </summary>
        [JsonProperty("dayOfWeekIndex")]
        public RecurrenceDayOfWeekIndex? DayOfWeekIndex { get; internal set; }

        /// <summary>
        /// Whether recurrency should be temporarily disabled.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The frequency of the recurrency.
        /// </summary>
        [JsonProperty("frequency")]
        public RecurrenceFrequency? Frequency { get; internal set; }

        /// <summary>
        /// The interval of the Frequency, e.g. every 2nd week or every 10th day.
        /// </summary>
        [JsonProperty("interval")]
        public long? Interval { get; internal set; }

        /// <summary>
        /// <br>_Required_ when `frequency` is `yearly`, ignored in all other cases. List of months of the year, e.g. `3,6,9,12`.</br>
        /// <br>- `1`: January</br>
        /// <br>- `2`: February</br>
        /// <br>- `3`: March</br>
        /// <br>- `4`: April</br>
        /// <br>- `5`: May</br>
        /// <br>- `6`: June</br>
        /// <br>- `7`: July</br>
        /// <br>- `8`: August</br>
        /// <br>- `9`: September</br>
        /// <br>- `10`: October</br>
        /// <br>- `11`: November</br>
        /// <br>- `12`: December</br>.
        /// </summary>
        [JsonProperty("monthOfYear")]
        public List<long>? MonthOfYear { get; internal set; }

        /// <summary>
        /// The time of day to start the scheduled occurrence.
        /// </summary>
        [JsonProperty("timeOfDay")]
        public TimeSpan? TimeOfDay { get; internal set; }

        /// <summary>
        /// <br>The time zone for the `timeOfDay` field.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see></br>.
        /// </summary>
        [JsonProperty("timeZone")]
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
