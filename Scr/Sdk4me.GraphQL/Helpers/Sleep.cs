using System.Diagnostics;
using System.Threading;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A class to force a 100 milliseconds sleep minus the request processing time.
    /// </summary>
    internal static class Sleep
    {
        private static readonly Stopwatch stopwatch = new();

        /// <summary>
        /// Returns the last HTTP request response time.
        /// </summary>
        internal static long ResponseTimeInMilliseconds
        {
            get => stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Stores the current Environment.TickCount value. This value will be used by the <see cref="SleepRemainingTime"/> method.
        /// </summary>
        internal static void RegisterStartTime()
        {
            stopwatch.Restart();
        }

        /// <summary>
        /// Puts the current thread in sleep for 100 milliseconds minus the elapsed milliseconds between now an the value stored via the <see cref="RegisterStartTime"/> method.
        /// </summary>
        internal static void SleepRemainingTime(int minimumDurationPerRequestInMiliseconds = 100)
        {
            stopwatch.Stop();
            if (stopwatch.ElapsedMilliseconds < minimumDurationPerRequestInMiliseconds)
                Thread.Sleep(stopwatch.ElapsedMilliseconds <= int.MaxValue ? minimumDurationPerRequestInMiliseconds - (int)stopwatch.ElapsedMilliseconds : minimumDurationPerRequestInMiliseconds);
        }
    }
}
