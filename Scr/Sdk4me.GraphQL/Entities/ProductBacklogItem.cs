using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productbacklogitem/">ProductBacklogItem</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class ProductBacklogItem : Node
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
        /// Product backlog this item is placed on.
        /// </summary>
        [JsonProperty("productBacklog"), Sdk4meField(true)]
        public ProductBacklog? ProductBacklog { get; internal set; }

        /// <summary>
        /// Estimate of the relative size of this item on the product backlog.
        /// </summary>
        [JsonProperty("productBacklogEstimate"), Sdk4meField(true)]
        public long? ProductBacklogEstimate { get; internal set; }

        /// <summary>
        /// The (one based) position of this item on the backlog.
        /// </summary>
        [JsonProperty("productBacklogPosition"), Sdk4meField(true)]
        public long? ProductBacklogPosition { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
