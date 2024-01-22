namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of <see cref="DateTime"/> extension methods.
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// Is the date time a 'Best effort' value?
        /// </summary>
        /// <param name="dateTime">The date time object.</param>
        /// <returns>Returns true when the value matches the Sdk4me predefined 'best effort' date time value (0001-01-01T01:01:01.111Z)</returns>
        public static bool IsBestEffort(this DateTime dateTime)
        {
            return dateTime == DateTimeValue.BestEffortDateTime;
        }

        /// <summary>
        /// Is the date time a 'No target' value?
        /// </summary>
        /// <param name="dateTime">The date time object.</param>
        /// <returns>Returns true when the value matches the Sdk4me predefined 'no target' date time value (0002-02-02T02:02:02.222Z)</returns>
        public static bool IsNoTarget(this DateTime dateTime)
        {
            return dateTime == DateTimeValue.NoTargetDateTime;
        }

        /// <summary>
        /// Is the date time a 'Clock stopped' value?
        /// </summary>
        /// <param name="dateTime">The date time object.</param>
        /// <returns>Returns true when the value matches the Sdk4me predefined 'clock stopped' date time value (0003-03-03T03:03:03.333Z)</returns>
        public static bool IsClockStopped(this DateTime dateTime)
        {
            return dateTime == DateTimeValue.ClockStoppedDateTime;
        }
    }
}
