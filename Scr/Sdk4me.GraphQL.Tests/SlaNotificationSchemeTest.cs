namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class SlaNotificationSchemeTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<SlaNotificationScheme> slaNotificationSchemes = client.Get(Query.SlaNotificationScheme
                .View(DefaultView.None)
                .SelectAll()
                .SelectSlaNotificationRules(new SlaNotificationRuleQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(slaNotificationSchemes);
            Console.WriteLine($"Count: {slaNotificationSchemes.Count}");
        }
    }
}
