using Microsoft.Extensions.Configuration;

namespace Sdk4me.GraphQL.Tests
{
    internal class Client
    {
        private static Sdk4meClient? client;

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
                client = new(new AuthenticationToken(clientID, clientSecret), account, EnvironmentType.Demo, EnvironmentRegion.EU, 5)
                {
                    MaximumQueryDepthLevelConnections = 3
                };
            }
            else if (!string.IsNullOrEmpty(token))
            {
                client = new(new AuthenticationToken(token), account, EnvironmentType.Demo, EnvironmentRegion.EU, 5)
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
