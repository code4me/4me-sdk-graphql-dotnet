using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of 4me specific date time values.
    /// </summary>
    public static class DateTimeValue
    {
        private static readonly DateTime bestEffort = new(1, 1, 1, 1, 1, 1, 111);
        private static readonly DateTime noTarget = new(2, 2, 2, 2, 2, 2, 222);
        private static readonly DateTime clockStopped = new(3, 3, 3, 3, 3, 3, 333);

        /// <summary>
        /// The 4me 'best effort' string value.
        /// </summary>
        public const string BestEffortText = "best_effort";

        /// <summary>
        /// The 4me 'no target' string value.
        /// </summary>
        public const string NoTargetText = "no_target";

        /// <summary>
        /// The 4me 'clocked stopped' string value.
        /// </summary>
        public const string ClockStoppedText = "clock_stopped";

        /// <summary>
        /// The Sdk4me predefined 'best effort' date time value.
        /// </summary>
        public static DateTime BestEffortDateTime => bestEffort;

        /// <summary>
        /// The Sdk4me predefined 'no target' date time value.
        /// </summary>
        public static DateTime NoTargetDateTime => noTarget;

        /// <summary>
        /// The Sdk4me predefined 'clock stopped' date time value.
        /// </summary>
        public static DateTime ClockStoppedDateTime => clockStopped;
    }
}
