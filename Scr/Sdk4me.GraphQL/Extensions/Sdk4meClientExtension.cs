namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of quick access methods.
    /// </summary>
    public static class Sdk4meClientExtension
    {
        /// <summary>
        /// Query the 4me web service as an asynchronous operation using the <see cref="MeQuery"/> query.
        /// </summary>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<Person> Me(this Sdk4meClient client)
        {
            DataList<Person> people = await client.Get<Person>(Query.Me.SelectAll());
            return people.First();
        }

        /// <summary>
        /// Query the 4me web service as an asynchronous operation using the <see cref="AccountQuery"/> query.
        /// </summary>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<Account> Account(this Sdk4meClient client)
        {
            DataList<Account> accounts = await client.Get<Account>(Query.Account.SelectAll());
            return accounts.First();
        }

        /// <summary>
        /// Query the 4me web service as an asynchronous operation using the <see cref="RateLimitQuery"/> query.
        /// <br>This returns the cost rate limit, not the request rate limit.</br>
        /// <br>More information about the different types of rate limits can be found on the <see href="https://developer.4me.com/graphql/#rate-limits"/>4me developer pages.</br>
        /// </summary>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<RateLimit> RateLimit(this Sdk4meClient client)
        {
            DataList<RateLimit> rateLimits = await client.Get<RateLimit>(Query.RateLimit.SelectAll());
            return rateLimits.First();
        }
    }
}
