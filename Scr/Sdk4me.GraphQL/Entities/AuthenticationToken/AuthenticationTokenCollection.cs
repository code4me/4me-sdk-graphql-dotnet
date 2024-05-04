using System;
using System.Collections;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me authentication token collection.
    /// </summary>
    public sealed class AuthenticationTokenCollection : IEnumerable<AuthenticationToken>
    {
        private readonly AuthenticationTokenSorter authenticationTokenSorter = new();
        private readonly List<AuthenticationToken> authenticationTokens = new();

        /// <summary>
        /// Create a new instance of an <see cref="AuthenticationTokenCollection"/>.
        /// </summary>
        public AuthenticationTokenCollection()
        {
        }

        /// <summary>
        /// Gets or sets the weight for prioritizing remaining requests when calculating the token usage prioritization, the default value is 0.6.
        /// <para>
        /// <br>Represents the weight assigned to remaining API requests when determining the score for an authentication token.</br>
        /// <br>By adjusting this weight, you can influence the sorting of tokens to prioritize those with a greater number of remaining API requests.</br>
        /// <br>A higher <c>RequestsWeight</c> places more emphasis on tokens with more available requests.</br>
        /// </para>
        /// <para>To find additional information regarding Service Quotas, please refer to the <see href="https://developer.4me.com/graphql/#service-quotas-1">4me developer documentation</see>.</para>
        /// </summary>
        public double RequestWeight
        {
            get => authenticationTokenSorter.RequestWeight;
            set => authenticationTokenSorter.RequestWeight = value;
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
        public double CostWeight
        {
            get => authenticationTokenSorter.CostWeight;
            set => authenticationTokenSorter.CostWeight = value;
        }

        /// <summary>
        /// Returns the 4me authentication token with the highest remaining request and/or cost.
        /// </summary>
        /// <returns>A <see cref="AuthenticationToken"/> object.</returns>
        public AuthenticationToken Get()
        {
            if (authenticationTokens.Count.Equals(0))
                throw new Sdk4meTokenNullReferenceException("The collection does not contain any token.");

            if (authenticationTokens.Count > 1)
                authenticationTokens.Sort(authenticationTokenSorter);

            if (authenticationTokens[0].RequestsRemaining < 1 && authenticationTokens[0].RequestLimitReset > DateTime.Now)
                throw new Sdk4meException("There are no remaining API requests for the provided authentication tokens.");

            if (authenticationTokens[0].CostLimitRemaining < 1 && authenticationTokens[0].CostLimitReset > DateTime.Now)
                throw new Sdk4meException("There are no remaining cost points for the provided authentication tokens.");

            return authenticationTokens[0];
        }

        /// <summary>
        /// Create a new instance of an <see cref="AuthenticationTokenCollection"/> with <b>Personal Access Token</b> authentication.
        /// </summary>
        /// <param name="authenticationToken">The 4me Personal Access Token.</param>
        public AuthenticationTokenCollection(string authenticationToken)
        {
            Add(authenticationToken);
        }

        /// <summary>
        /// Create a new instance of an <see cref="AuthenticationTokenCollection"/> with <b>OAuth 2.0 Client Credentials Grant</b> authentication.
        /// </summary>
        /// <param name="clientID">The 4me OAuth 2.0 client grant client ID.</param>
        /// <param name="clientSecret">The 4me OAuth 2.0 client grant client secret.</param>
        public AuthenticationTokenCollection(string clientID, string clientSecret)
        {
            Add(clientID, clientSecret);
        }

        /// <summary>
        /// Create a new instance of an <see cref="AuthenticationTokenCollection"/>.
        /// </summary>
        /// <param name="authenticationToken">A 4me authentication token to add to the collection.</param>
        public AuthenticationTokenCollection(AuthenticationToken authenticationToken)
        {
            Add(authenticationToken);
        }

        /// <summary>
        /// Add a 4me Personal Access Token to the collection.
        /// </summary>
        /// <param name="authenticationToken">The 4me Personal Access Token.</param>
        public void Add(string authenticationToken)
        {
            Add(new AuthenticationToken(authenticationToken));
        }

        /// <summary>
        /// Add a 4me OAuth 2.0 client grant credential to the collection.
        /// </summary>
        /// <param name="clientID">The 4me OAuth 2.0 client grant client ID.</param>
        /// <param name="clientSecret">The 4me OAuth 2.0 client grant client secret.</param>
        public void Add(string clientID, string clientSecret)
        {
            Add(new AuthenticationToken(clientID, clientSecret));
        }

        /// <summary>
        /// Adds a 4me authentication token to the collection.
        /// </summary>
        /// <param name="authenticationToken">The 4me authentication token.</param>
        public void Add(AuthenticationToken authenticationToken)
        {
            if (authenticationToken is null)
                throw new Sdk4meTokenNullReferenceException(nameof(authenticationToken));

            if (string.IsNullOrWhiteSpace(authenticationToken.Token) && (string.IsNullOrWhiteSpace(authenticationToken.ClientID) || string.IsNullOrWhiteSpace(authenticationToken.ClientSecret)))
                throw new Sdk4meTokenNullReferenceException($"Missing Client ID and Client Secret, or Personal Access Token");

            for (int i = 0; i < authenticationTokens.Count; i++)
            {
                if (authenticationTokens[i].Identifier == authenticationToken.Identifier)
                    return;
            }
            authenticationTokens.Add(authenticationToken);
        }

        /// <summary>
        /// Removes a 4me authentication token from the collection.
        /// </summary>
        /// <param name="authenticationToken">The 4me authentication token.</param>
        public void Remove(string authenticationToken)
        {
            Remove(new AuthenticationToken(authenticationToken));
        }

        /// <summary>
        /// Removes a 4me authentication token from the collection.
        /// </summary>
        /// <param name="authenticationToken">The 4me authentication token.</param>
        public void Remove(AuthenticationToken authenticationToken)
        {
            if (authenticationToken is null)
                throw new Sdk4meTokenNullReferenceException(nameof(authenticationToken));

            if (string.IsNullOrWhiteSpace(authenticationToken.Token) && (string.IsNullOrWhiteSpace(authenticationToken.ClientID) || string.IsNullOrWhiteSpace(authenticationToken.ClientSecret)))
                throw new Sdk4meTokenNullReferenceException($"Missing Client ID and Client Secret, or Personal Access Token");

            for (int i = authenticationTokens.Count - 1; i >= 0; i--)
            {
                if (authenticationTokens[i].Identifier == authenticationToken.Identifier)
                {
                    authenticationTokens.RemoveAt(i);
                    return;
                }
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the AuthenticationTokenCollection.
        /// </summary>
        /// <returns>A AuthenticationTokenCollection.Enumerator for the AuthenticationTokenCollection.</returns>
        public IEnumerator<AuthenticationToken> GetEnumerator()
        {
            return authenticationTokens.GetEnumerator();
        }

        /// <summary>
        /// Removes all elements from the AuthenticationTokenCollection.
        /// </summary>
        public void Clear()
        {
            authenticationTokens.Clear();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the AuthenticationTokenCollection.
        /// </summary>
        /// <returns>A AuthenticationTokenCollection.Enumerator for the AuthenticationTokenCollection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return authenticationTokens.GetEnumerator();
        }
    }
}
