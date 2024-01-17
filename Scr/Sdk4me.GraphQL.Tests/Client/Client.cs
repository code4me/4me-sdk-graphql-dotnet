using Microsoft.Extensions.Configuration;

namespace Sdk4me.GraphQL.Tests
{
    internal class Client
    {
        private static Sdk4meClient? client;
        private static readonly AuthenticationTokenCollection authenticationTokens = new();

        public static AuthenticationTokenCollection AuthenticationTokens 
        {
            get => authenticationTokens;
        }

        public static Sdk4meClient Get() 
        {
            if (client != null)
                return client;

            //get all information
            IConfigurationProvider secretProvider = new ConfigurationBuilder().AddUserSecrets<ConnectionSecret>().Build().Providers.First();
            if (!secretProvider.TryGet("Account", out string? account) 
                || !secretProvider.TryGet("Token", out string? token) 
                || !secretProvider.TryGet("ClientID", out string? clientID)
                || !secretProvider.TryGet("ClientSecret", out string? clientSecret))
            {
                Assert.Fail("Missing information in the user secret file");
                return null;
            }

            if (account == null || token == null || clientID == null || clientSecret == null)
            {
                Assert.Fail("Null value information in the user secret file");
                return null;
            }

            if (!string.IsNullOrEmpty(clientID) && !string.IsNullOrWhiteSpace(clientSecret))
            {
                authenticationTokens.Add(clientID, clientSecret);
                client = new(authenticationTokens, account, EnvironmentType.Demo, EnvironmentRegion.EU, 5)
                {
                    MaximumQueryDepthLevelConnections = 3
                };
            }
            else if (!string.IsNullOrEmpty(token))
            {
                authenticationTokens.Add(token);
                client = new(authenticationTokens, account, EnvironmentType.Demo, EnvironmentRegion.EU, 5)
                {
                    MaximumQueryDepthLevelConnections = 3
                };
            }
            else
            {
                Assert.Fail("Invalid information in the user secret file");
                return null;
            }
            return client;
        }
    }
}
