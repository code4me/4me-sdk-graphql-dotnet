using Newtonsoft.Json;
using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/calendarhoursinput/">CalendarHoursInput</see> object.
    /// </summary>
    public class CalendarHoursInput : PropertyChangeSet
    {
        private string? id;
        private TimeSpan? timeFrom;
        private TimeSpan? timeUntil;
        private Weekday? weekday;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The time at which the calendar becomes active on the given weekday.
        /// </summary>
        [JsonProperty("timeFrom")]
        public TimeSpan? TimeFrom
        {
            get => timeFrom;
            set => timeFrom = Set("timeFrom", value);
        }

        /// <summary>
        /// The time at which the calendar stops being active on the given weekday.
        /// </summary>
        [JsonProperty("timeUntil")]
        public TimeSpan? TimeUntil
        {
            get => timeUntil;
            set => timeUntil = Set("timeUntil", value);
        }

        /// <summary>
        /// The day of the week.
        /// </summary>
        [JsonProperty("weekday")]
        public Weekday? Weekday
        {
            get => weekday;
            set => weekday = Set("weekday", value);
        }
    }
}
