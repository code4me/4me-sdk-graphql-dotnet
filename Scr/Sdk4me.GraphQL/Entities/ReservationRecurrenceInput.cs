using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/reservationrecurrenceinput/">ReservationRecurrenceInput</see> object.
    /// </summary>
    public class ReservationRecurrenceInput : PropertyChangeSet
    {
        private List<long>? day;
        private List<long>? dayOfMonth;
        private bool? dayOfWeek;
        private List<DayNames>? dayOfWeekDay;
        private RecurrenceDayOfWeekIndex? dayOfWeekIndex;
#if NET6_0_OR_GREATER
        private DateOnly? endDate;
#else
        private DateTime? endDate;
#endif
        private RecurrenceFrequency? frequency;
        private long? interval;
        private List<long>? monthOfYear;
#if NET6_0_OR_GREATER
        private DateOnly? startDate;
#else
        private DateTime? startDate;
#endif
        private TimeSpan? timeOfDay;
        private string? timeZone;

        /// <summary>
        /// <br><em>Required</em> when <c>frequency</c> is <c>daily</c>, ignored in all other cases. List of days of the week, e.g. <c>1,2,3,4,5</c>.</br>
        /// <br>• <c>0</c>: Sunday</br>
        /// <br>• <c>1</c>: Monday</br>
        /// <br>• <c>2</c>: Tuesday</br>
        /// <br>• <c>3</c>: Wednesday</br>
        /// <br>• <c>4</c>: Thursday</br>
        /// <br>• <c>5</c>: Friday</br>
        /// <br>• <c>6</c>: Saturday</br>
        /// </summary>
        [JsonProperty("day")]
        public List<long>? Day
        {
            get => day;
            set => day = Set("day", value);
        }

        /// <summary>
        /// <br><em>Required</em> when <c>frequency</c> is <c>monthly</c> and <c>day_of_week</c> is <c>false</c>, ignored in all other cases. List of days of the month, e.g. <c>11,21,-1</c>.</br>
        /// <br>• <c>1</c>: Day one</br>
        /// <br>• <c>2</c>: Day two</br>
        /// <br>• <c>3</c>: Day three</br>
        /// <br>• ...</br>
        /// <br>• <c>30</c>: Day thirty</br>
        /// <br>• <c>31</c>: Day thirty-one</br>
        /// <br>• <c>-1</c>: Last day of month</br>
        /// </summary>
        [JsonProperty("dayOfMonth")]
        public List<long>? DayOfMonth
        {
            get => dayOfMonth;
            set => dayOfMonth = Set("dayOfMonth", value);
        }

        /// <summary>
        /// Indicates whether or not the <c>dayOfWeekIndex</c> and <c>dayOfWeekDay</c> values should be considered. Can only be set to <c>true</c> when <c>frequency</c> is <c>monthly</c> or <c>yearly</c>.
        /// </summary>
        [JsonProperty("dayOfWeek")]
        public bool? DayOfWeek
        {
            get => dayOfWeek;
            set => dayOfWeek = Set("dayOfWeek", value);
        }

        /// <summary>
        /// <em>Required</em> when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases. list of days of the week.
        /// </summary>
        [JsonProperty("dayOfWeekDay")]
        public List<DayNames>? DayOfWeekDay
        {
            get => dayOfWeekDay;
            set => dayOfWeekDay = Set("dayOfWeekDay", value);
        }

        /// <summary>
        /// <em>Required</em> when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases.
        /// </summary>
        [JsonProperty("dayOfWeekIndex")]
        public RecurrenceDayOfWeekIndex? DayOfWeekIndex
        {
            get => dayOfWeekIndex;
            set => dayOfWeekIndex = Set("dayOfWeekIndex", value);
        }

        /// <summary>
        /// The date at which to end the Recurrence.
        /// </summary>
        [JsonProperty("endDate")]
#if NET6_0_OR_GREATER
        public DateOnly? EndDate
#else
        public DateTime? EndDate
#endif
        {
            get => endDate;
            set => endDate = Set("endDate", value);
        }

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
        /// <br><em>Required</em> when <c>frequency</c> is <c>yearly</c>, ignored in all other cases. List of months of the year, e.g. <c>3,6,9,12</c>.</br>
        /// <br>• <c>1</c>: January</br>
        /// <br>• <c>2</c>: February</br>
        /// <br>• <c>3</c>: March</br>
        /// <br>• <c>4</c>: April</br>
        /// <br>• <c>5</c>: May</br>
        /// <br>• <c>6</c>: June</br>
        /// <br>• <c>7</c>: July</br>
        /// <br>• <c>8</c>: August</br>
        /// <br>• <c>9</c>: September</br>
        /// <br>• <c>10</c>: October</br>
        /// <br>• <c>11</c>: November</br>
        /// <br>• <c>12</c>: December</br>
        /// </summary>
        [JsonProperty("monthOfYear")]
        public List<long>? MonthOfYear
        {
            get => monthOfYear;
            set => monthOfYear = Set("monthOfYear", value);
        }

        /// <summary>
        /// The date at which to start the Recurrence.
        /// </summary>
        [JsonProperty("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate
#else
        public DateTime? StartDate
#endif
        {
            get => startDate;
            set => startDate = Set("startDate", value);
        }

        /// <summary>
        /// The time of day to start the Recurrence.
        /// </summary>
        [JsonProperty("timeOfDay")]
        public TimeSpan? TimeOfDay
        {
            get => timeOfDay;
            set => timeOfDay = Set("timeOfDay", value);
        }

        /// <summary>
        /// <br>The time zone for the <c>timeOfDay</c> field.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }
    }
}
