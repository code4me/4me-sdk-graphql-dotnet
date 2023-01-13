namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Compares two 4me authentication tokens and sort them by remaining API requests.
    /// </summary>
    public sealed class AuthenticationTokenSorter : IComparer<AuthenticationToken>
    {
        /// <summary>
        /// Compares two 4me authentication and returns sort them by remaining API requests and limit values.
        /// </summary>
        /// <param name="x">The first <see cref="AuthenticationToken"/> to compare.</param>
        /// <param name="y">The second <see cref="AuthenticationToken"/> to compare.</param>
        /// <returns>A signed integer that indicates the relative values of the first and second <see cref="AuthenticationToken"/>.</returns>
        public int Compare(AuthenticationToken? x, AuthenticationToken? y)
        {
            if (x is null || y is null)
                return 0;

            int sortValue = y.RequestsRemaining.CompareTo(x.RequestsRemaining);
            return (sortValue == 0) ? x.RequestLimitReset.CompareTo(y.RequestLimitReset) : sortValue;
        }
    }
}
