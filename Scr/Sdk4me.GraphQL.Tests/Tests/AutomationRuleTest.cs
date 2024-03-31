namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class AutomationRuleTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<AutomationRule> automationRules = client.Get(Query.AutomationRule
                .View(AutomationRuleView.All)
                .SelectAll()
                .SelectOwner(new RequestQuery()
                    .SelectAll()
                    .ItemsPerRequest(1)
                    .SelectAutomationRules(new AutomationRuleQuery()
                        .SelectAll()))
                ).Result;

            Assert.IsNotNull(automationRules);
            Console.WriteLine($"Count: {automationRules.Count}");

        }
    }
}
