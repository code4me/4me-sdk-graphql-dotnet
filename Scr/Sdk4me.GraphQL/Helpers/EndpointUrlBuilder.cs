namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Get the 4me GraphQL URL.
    /// </summary>
    internal static class EndpointUrlBuilder
    {
        /// <summary>
        /// Returns the domain name for a specific environment.
        /// </summary>
        /// <param name="environment">The environment type.</param>
        /// <param name="environmentRegion">The environment region.</param>
        /// <returns>The API endpoint URL for the specified environment.</returns>
        internal static string GetDomainName(EnvironmentRegion environmentRegion, EnvironmentType environment)
        {
            return environmentRegion switch
            {
                EnvironmentRegion.AU => environment switch
                {
                    EnvironmentType.Quality => "au.4me.qa",
                    EnvironmentType.Demo => "4me-demo.com",
                    _ => "au.4me.com",
                },
                EnvironmentRegion.UK => environment switch
                {
                    EnvironmentType.Quality => "uk.4me.qa",
                    EnvironmentType.Demo => "4me-demo.com",
                    _ => "uk.4me.com",
                },
                EnvironmentRegion.US => environment switch
                {
                    EnvironmentType.Quality => "us.4me.qa",
                    EnvironmentType.Demo => "4me-demo.com",
                    _ => "us.4me.com",
                },
                EnvironmentRegion.CH => environment switch
                {
                    EnvironmentType.Quality => "ch.4me.qa",
                    EnvironmentType.Demo => "4me-demo.com",
                    _ => "ch.4me.com",
                },
                _ => environment switch
                {
                    EnvironmentType.Quality => "4me.qa",
                    EnvironmentType.Demo => "4me-demo.com",
                    _ => "4me.com",
                },
            };
        }

        /// <summary>
        /// Returns the API endpoint URL for a custom domain.
        /// </summary>
        /// <param name="domainName">The custom domain name.</param>
        /// <returns>The API endpoint URL for the specified custom domain.</returns>
        internal static string Get(string domainName)
        {
            return $"https://graphql.{domainName}";
        }

        /// <summary>
        /// Returns the REST API endpoint for a custom domain.
        /// </summary>
        /// <param name="domainName">The custom domain name.</param>
        /// <returns>The REST API endpoint URL for the specified custom domain.</returns>
        internal static string GetRest(string domainName)
        {
            return $"https://api.{domainName}/v1";
        }

        /// <summary>
        /// Returns the OAuth 2.0 authentication URL for a custom domain.
        /// </summary>
        /// <param name="domainName">The custom domain name.</param>
        /// <returns>The OAuth 2.0 authentication URL for the specified custom domain.</returns>
        internal static string GetOAuth2(string domainName)
        {
            return $"https://oauth.{domainName}/token";
        }
    }
}
