using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Errors encountered during the mutation.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    [DebuggerDisplay("{Message}")]
    public class ValidationError : Node
    {
        /// <summary>
        /// A description of the error.
        /// </summary>
        [JsonProperty("message"), Sdk4meField(true)]
        public string? Message { get; set; }

        /// <summary>
        /// Which input value this error came from.
        /// </summary>
        [JsonProperty("path"), Sdk4meField(true)]
        public List<string>? Path { get; set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
