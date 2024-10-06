using System;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A class to force a 100 milliseconds sleep minus the request processing time.
    /// </summary>
    internal class Sleep
    {
        private readonly Stopwatch stopwatch;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep"/> class.
        /// </summary>
        public Sleep()
        {
            stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Returns the last HTTP request response time in milliseconds.
        /// </summary>
        internal long ResponseTimeInMilliseconds
        {
            get => stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Stores the current start time by restarting the stopwatch.
        /// This method should be called before initiating the request.
        /// </summary>
        internal void RegisterStartTime()
        {
            stopwatch.Restart();
        }

        /// <summary>
        /// Asynchronously puts the current task in delay for the remaining time to ensure the request takes at least the specified minimum duration.
        /// </summary>
        /// <param name="minimumDurationPerRequestInMilliseconds">The minimum duration each request should take, in milliseconds. Defaults to 100 ms.</param>
        /// <returns>A task representing the asynchronous delay operation.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the specified minimum duration is not positive.</exception>
        public async System.Threading.Tasks.Task SleepRemainingTime(int minimumDurationPerRequestInMilliseconds = 100)
        {
            stopwatch.Stop();

            if (minimumDurationPerRequestInMilliseconds <= 0)
                return;

            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            long remainingTime = minimumDurationPerRequestInMilliseconds - elapsedMilliseconds;

            if (remainingTime > 0)
            {
                if (remainingTime > int.MaxValue)
                    remainingTime = minimumDurationPerRequestInMilliseconds;

                await System.Threading.Tasks.Task.Delay((int)remainingTime).ConfigureAwait(false);
            }
        }
    }
}
