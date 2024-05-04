using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
                .SelectOwner(new ProjectTaskQuery()
                    .SelectAll()
                    .ItemsPerRequest(1)
                    .SelectAutomationRules(new AutomationRuleQuery()
                        .SelectAll()))
                .SelectOwner(new ProjectTaskTemplateQuery()
                    .Select("id")
                    .ItemsPerRequest(1))
                .SelectOwner(new ProjectTaskTemplateRelationQuery()
                    .Select("id")
                    .ItemsPerRequest(1))
                .SelectOwner(new RequestQuery()
                    .SelectAll()
                    .ItemsPerRequest(1))
                .SelectOwner(new RequestTemplateQuery()
                    .Select("id")
                    .ItemsPerRequest(1))
                .SelectOwner(new TaskQuery()
                    .Select("id")
                    .ItemsPerRequest(1))
                .SelectOwner(new TaskTemplateQuery()
                    .Select("id")
                    .ItemsPerRequest(1))
                .SelectOwner(new WorkflowQuery()
                    .SelectAll()
                    .ItemsPerRequest(1))
                .SelectOwner(new WorkflowTaskTemplateRelationQuery()
                    .Select("id")
                    .ItemsPerRequest(1))
                .SelectOwner(new WorkflowTemplateQuery()
                    .Select("id")
                    .ItemsPerRequest(1))
                ).Result;

            Assert.IsNotNull(automationRules);
            Console.WriteLine($"Count: {automationRules.Count}");

        }
    }
}
