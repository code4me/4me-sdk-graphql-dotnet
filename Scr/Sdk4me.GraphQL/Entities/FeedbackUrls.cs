using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/feedbackurls/">FeedbackUrls</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class FeedbackUrls : Node
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
        /// Hyperlink that can be used to indicate dissatisfaction with the request resolution.
        /// </summary>
        [JsonProperty("dissatisfiedUrl"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? DissatisfiedUrl { get; internal set; }

        /// <summary>
        /// Hyperlink that can be used to indicate satisfaction with the request resolution.
        /// </summary>
        [JsonProperty("satisfiedUrl"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? SatisfiedUrl { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
