namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Compares two 4me authentication tokens and sort them by remaining API requests.
    /// </summary>
    public sealed class AuthenticationTokenSorter : IComparer<AuthenticationToken>
    {
        private double requestsWeight = 0.6;
        private double costWeight = 0.4;

        /// <summary>
        /// <para>Gets or sets the weight for prioritizing remaining requests when calculating token scores, the default value is 0.6.</para>
        /// <para>
        /// <br>Represents the weight assigned to remaining API requests when determining the score for an authentication token.</br>
        /// <br>By adjusting this weight, you can influence the sorting of tokens to prioritize those with a greater number of remaining API requests.</br>
        /// <br>A higher <c>RequestsWeight</c> places more emphasis on tokens with more available requests.</br>
        /// </para>
        /// <para>To find additional information regarding Service Quotas, please refer to the <see href="https://developer.4me.com/graphql/#service-quotas-1">4me developer documentation</see>.</para>
        /// </summary>
        internal double RequestWeight
        {
            get => requestsWeight;
            set => requestsWeight = value;
        }

        /// <summary>
        /// Gets or sets the weight for prioritizing remaining cost when calculating the token usage prioritization, the default value is 0.4.
        /// <para>
        /// <br>Represents the weight assigned to the remaining cost associated with using an authentication token.</br>
        /// <br>By adjusting this weight, you can influence the sorting of tokens to prioritize those with a higher remaining cost.</br>
        /// <br>A higher <c>CostWeight</c> places more emphasis on tokens with higher remaining cost.</br>
        /// </para>
        /// <para>To find additional information regarding Service Quotas, please refer to the <see href="https://developer.4me.com/graphql/#service-quotas-1">4me developer documentation</see>.</para>
        /// </summary>
        internal double CostWeight
        {
            get => costWeight;
            set => costWeight = value;
        }
        
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

            return CalculateTokenScore(y).CompareTo(CalculateTokenScore(x));
        }

        /// <summary>
        /// Calculates a score for a 4me authentication token based on the remaining requests and cost.
        /// </summary>
        /// <param name="token">The AuthenticationToken to calculate the score for.</param>
        /// <returns>The calculated score for the AuthenticationToken.</returns>
        private double CalculateTokenScore(AuthenticationToken token)
        {
            if (token.RequestsRemaining > 0 && token.CostLimitRemaining > 0)
                return (double)((double)token.RequestsRemaining / token.RequestLimit * RequestWeight + (double)token.CostLimitRemaining / token.CostLimit * CostWeight);
            return 0;
        }
    }
}
