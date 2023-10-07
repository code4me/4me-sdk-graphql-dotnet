using System.Diagnostics;
using System.Text;

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
        public virtual long GetIdentifier()
        {
            if (string.IsNullOrWhiteSpace(ID))
                return 0;

            string value = ID.Replace('-', '+').Replace('_', '/').Replace(',', '=');
            switch (value.Length % 4)
            {
                case 0:
                    value = Encoding.UTF8.GetString(Convert.FromBase64String(value));
                    break;
                case 2:
                    value = Encoding.UTF8.GetString(Convert.FromBase64String(value + "=="));
                    break;
                case 3:
                    value = Encoding.UTF8.GetString(Convert.FromBase64String(value + "="));
                    break;
                default:
                    return 0;
            }

            if (long.TryParse(value.Split('/')[^1], out long result))
                return result;
            return 0;
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
