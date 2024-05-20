using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/ratelimit/">RateLimit</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class RateLimit : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => (Remaining is not null && Limit is not null) ? $"{Remaining}/{Limit}" : ToString();
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
        /// The point cost for the current call that counts against the query cost rate limit.
        /// </summary>
        [JsonProperty("cost"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? Cost { get; internal set; }

        /// <summary>
        /// The maximum number of points the client is permitted to consume in a 60-minutes window.
        /// </summary>
        [JsonProperty("limit"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? Limit { get; internal set; }

        /// <summary>
        /// The number of points remaining in the current query cost rate limit window.
        /// </summary>
        [JsonProperty("remaining"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? Remaining { get; internal set; }

        /// <summary>
        /// The time at which the current query cost rate limit window resets in <see href="https://en.wikipedia.org/wiki/Unix_time">UTC epoch seconds</see>.
        /// </summary>
        [JsonProperty("resetAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? ResetAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
