using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class AppOfferingTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<AppOffering> appOfferings = client.Get(Query.AppOffering
                .View(AppOfferingView.All)
                .SelectAll()
                .SelectAppInstances(new AppInstanceQuery()
                    .SelectAll())
                .SelectAutomationRules(new AppOfferingAutomationRuleQuery()
                    .SelectAll())
                .SelectComplianceAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(appOfferings);
            Console.WriteLine($"Count: {appOfferings.Count}");

            if (appOfferings.Any())
            {
                appOfferings = client.Get(new AppOfferingQuery(appOfferings.First().ID)).Result;
                Assert.IsNotNull(appOfferings);
            }
        }
    }
}
