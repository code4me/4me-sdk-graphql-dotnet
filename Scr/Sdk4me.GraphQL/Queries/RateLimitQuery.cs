namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The rate limit status.
    /// </summary>
    public class RateLimitQuery : Query<RateLimitQuery, RateLimitField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new rate limit query instance.
        /// </summary>
        public RateLimitQuery()
            : base("rateLimit", typeof(RateLimit), false)
        {
        }
    }
}
