namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me authentication token.
    /// </summary>
    public sealed class AuthenticationToken
    {
        private readonly string authenticationToken;
        private int requestLimit = int.MaxValue;
        private int requestsRemaining = int.MaxValue;
        private DateTime requestLimitReset = DateTime.MinValue;
        private DateTime updatedAt = DateTime.MinValue;

        /// <summary>
        /// Get the 4me authentication token.
        /// </summary>
        internal string Token
        {
            get => authenticationToken;
        }

        /// <summary>
        /// The maximum number of requests permitted to make in the current rate limit window.
        /// <br>The initial value is <see cref="int.MaxValue"/> because the actual value is still unknown.</br>
        /// </summary>
        public int RequestLimit
        {
            get => requestLimit;
            internal set => requestLimit = value;
        }

        /// <summary>
        /// The number of requests remaining in the current rate limit window.
        /// <br>The initial value is <see cref="int.MaxValue"/> because the actual value is still unknown.</br>
        /// </summary>
        public int RequestsRemaining
        {
            get => requestsRemaining;
            internal set => requestsRemaining = value;
        }

        /// <summary>
        /// The local time at which the current rate limit window resets.
        /// </summary>
        public DateTime RequestLimitReset
        {
            get => requestLimitReset;
            internal set => requestLimitReset = value;
        }

        /// <summary>
        /// Return the date and time when the request limit and remaining request values were updated.
        /// </summary>
        public DateTime UpdatedAt
        {
            get => updatedAt;
            internal set => updatedAt = value;
        }

        /// <summary>
        /// Create a new instance of an <see cref="AuthenticationToken"/>.
        /// </summary>
        /// <param name="authenticationToken">The 4me authentication token.</param>
        public AuthenticationToken(string authenticationToken)
        {
            this.authenticationToken = authenticationToken;
        }
    }
}
