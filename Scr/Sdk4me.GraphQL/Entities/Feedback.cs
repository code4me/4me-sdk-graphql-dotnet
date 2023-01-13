using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/feedback/">Feedback</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class Feedback : Node
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
        /// URLs to capture feedback from the person who submitted the request.
        /// </summary>
        [JsonProperty("requestedBy"), Sdk4meField(true)]
        public FeedbackUrls? RequestedBy { get; internal set; }

        /// <summary>
        /// URLs to capture feedback from the person for whom the request was submitted, if that was not the submitter of the request.
        /// </summary>
        [JsonProperty("requestedFor"), Sdk4meField(true)]
        public FeedbackUrls? RequestedFor { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
