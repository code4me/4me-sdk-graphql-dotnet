namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class WebhookPolicyTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<WebhookPolicy> webhookPolicies = client.Get(Query.WebhookPolicy
                .View(DefaultView.None)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(webhookPolicies);
            Console.WriteLine($"Count: {webhookPolicies.Count}");
        }
    }
}
