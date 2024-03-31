using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The base 4me object.
    /// </summary>
    [DebuggerDisplay("{DebuggerValue}")]
    public abstract class Node
    {
        /// <summary>
        /// The unique identifier.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(true)]
        public string ID { get; internal set; } = string.Empty;

        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal virtual string? DebuggerValue
        {
            get => ID;
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal virtual string UniqueIdentifier
        {
            get => ID;
        }

        /// <summary>
        /// Get the REST API numerical identifier.
        /// </summary>
        /// <returns>Returns the REST API numerical identifier; or 0 if the <see cref="ID"/> is null or empty.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public long GetIdentifier()
        {
            return ID.Get4meIdentifier();
        }

        /// <summary>
        /// Get the <see cref="QueryPageInfo"/> for all <see cref="NodeCollection{TEntity}"/> properties.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="depth">The query depth.</param>
        /// <returns>A query page info collection.</returns>
        internal abstract HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth);

        /// <summary>
        /// A generic method to merge collection properties of a derived <see cref="Node"/> object.
        /// </summary>
        /// <param name="data">The derived <see cref="Node"/> object to merge.</param>
        internal abstract void AddToCollection(object data);
    }
}
