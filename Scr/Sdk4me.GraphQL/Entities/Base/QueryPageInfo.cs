using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me GraphQL query page info object.
    /// </summary>
    internal class QueryPageInfo
    {
        private readonly string fieldName;
        private readonly string endCursor;
        private readonly int depth;

        /// <summary>
        /// The field name.
        /// </summary>
        internal string FieldName
        {
            get => fieldName;
        }

        /// <summary>
        /// The query depth.
        /// </summary>
        internal int Depth
        {
            get => depth;
        }

        /// <summary>
        /// The next page cursor.
        /// </summary>
        internal string EndCursor
        {
            get => endCursor;
        }

        /// <summary>
        /// Create a new instance of <see cref="QueryPageInfo"/>.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="depth">The query depth.</param>
        /// <param name="endCursor">The end cursor.</param>
        internal QueryPageInfo(string fieldName, int depth, string endCursor)
        {
            this.fieldName = fieldName;
            this.depth = depth;
            this.endCursor = endCursor;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as QueryPageInfo);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="queryPageInfo">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public bool Equals(QueryPageInfo? queryPageInfo)
        {
            return queryPageInfo is not null
                && fieldName == queryPageInfo.fieldName
                && depth == queryPageInfo.depth
                && endCursor == queryPageInfo.EndCursor;
        }

        /// <summary>
        /// Determines whether the two specified objects are equal.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public static bool operator ==(QueryPageInfo? x, QueryPageInfo? y)
        {
            return x is null ? (y is null) : x.Equals(y);
        }

        /// <summary>
        /// Determines whether the two specified objects are not equal.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public static bool operator !=(QueryPageInfo? x, QueryPageInfo? y)
        {
            return !(x == y);
        }

        /// <summary>
        /// The hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(fieldName, depth, endCursor);
        }
    }
}
