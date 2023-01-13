namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/reservationrecurrenceinput/">ReservationRecurrenceInput</see> object.
    /// </summary>
    public class ReservationRecurrenceInput : PropertyChangeSet
    {
        private RecurrenceFrequency? frequency;
        private long? interval;
        private DateOnly? startDate;
        private DateOnly? endDate;
        private List<long>? day;
        private List<long>? dayOfMonth;
        private bool? dayOfWeek;
        private RecurrenceDayOfWeekIndex? dayOfWeekIndex;
        private List<DayNames>? dayOfWeekDay;
        private List<long>? monthOfYear;

        /// <summary>
        /// The frequency of the recurrence.
        /// </summary>
        [JsonProperty("frequency")]
        public RecurrenceFrequency? Frequency
        {
            get => frequency;
            set => frequency = Set("frequency", value);
        }

        /// <summary>
        /// The interval of the Frequency, e.g. every 2nd week or every 10th day.
        /// </summary>
        [JsonProperty("interval")]
        public long? Interval
        {
            get => interval;
            set => interval = Set("interval", value);
        }

        /// <summary>
        /// The date at which to start the Recurrence.
        /// </summary>
        [JsonProperty("startDate")]
        public DateOnly? StartDate
        {
            get => startDate;
            set => startDate = Set("startDate", value);
        }

        /// <summary>
        /// The date at which to end the Recurrence.
        /// </summary>
        [JsonProperty("endDate")]
        public DateOnly? EndDate
        {
            get => endDate;
            set => endDate = Set("endDate", value);
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
        [JsonProperty("day")]
        public List<long>? Day
        {
            get => day;
            set => day = Set("day", value);
        }

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
        [JsonProperty("dayOfMonth")]
        public List<long>? DayOfMonth
        {
            get => dayOfMonth;
            set => dayOfMonth = Set("dayOfMonth", value);
        }

        /// <summary>
        /// Indicates whether or not the `dayOfWeekIndex` and `dayOfWeekDay` values should be considered. Can only be set to `true` when `frequency` is `monthly` or `yearly`.
        /// </summary>
        [JsonProperty("dayOfWeek")]
        public bool? DayOfWeek
        {
            get => dayOfWeek;
            set => dayOfWeek = Set("dayOfWeek", value);
        }

        /// <summary>
        /// _Required_ when `dayOfWeek` is `true`, ignored in all other cases.
        /// </summary>
        [JsonProperty("dayOfWeekIndex")]
        public RecurrenceDayOfWeekIndex? DayOfWeekIndex
        {
            get => dayOfWeekIndex;
            set => dayOfWeekIndex = Set("dayOfWeekIndex", value);
        }

        /// <summary>
        /// _Required_ when `dayOfWeek` is `true`, ignored in all other cases. list of days of the week.
        /// </summary>
        [JsonProperty("dayOfWeekDay")]
        public List<DayNames>? DayOfWeekDay
        {
            get => dayOfWeekDay;
            set => dayOfWeekDay = Set("dayOfWeekDay", value);
        }

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
        [JsonProperty("monthOfYear")]
        public List<long>? MonthOfYear
        {
            get => monthOfYear;
            set => monthOfYear = Set("monthOfYear", value);
        }
    }
}
