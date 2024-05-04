using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class RiskSeverityTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<RiskSeverity> riskSeverities = client.Get(Query.RiskSeverity
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new RiskSeverityQuery()
                        .SelectAll()
                        .ItemsPerRequest(1)))
                ).Result;

            Assert.IsNotNull(riskSeverities);
            Console.WriteLine($"Count: {riskSeverities.Count}");

            if (riskSeverities.Any())
            {
                riskSeverities = client.Get(new RiskSeverityQuery(riskSeverities.First().ID)).Result;
                Assert.IsNotNull(riskSeverities);
            }
        }
    }
}
