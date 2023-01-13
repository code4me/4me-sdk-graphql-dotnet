using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/calendarhour/">CalendarHour</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class CalendarHour : Node
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
        /// The time at which the calendar becomes active on the given weekday.
        /// </summary>
        [JsonProperty("timeFrom"), Sdk4meField(true)]
        public TimeSpan? TimeFrom { get; internal set; }

        /// <summary>
        /// The time at which the calendar stops being active on the given weekday.
        /// </summary>
        [JsonProperty("timeUntil"), Sdk4meField(true)]
        public TimeSpan? TimeUntil { get; internal set; }

        /// <summary>
        /// The day of the week.
        /// </summary>
        [JsonProperty("weekday"), Sdk4meField(true)]
        public Weekday? Weekday { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
