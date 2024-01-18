namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class WebhookTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Webhook> webhooks = client.Get(Query.Webhook
                .View(DefaultView.None)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(webhooks);
            Console.WriteLine($"Count: {webhooks.Count}");

            if (webhooks.Any())
            {
                webhooks = client.Get(new WebhookQuery(webhooks.First().ID)).Result;
                Assert.IsNotNull(webhooks);
            }
        }
    }
}
