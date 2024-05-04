using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class RiskTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Risk> risks = client.Get(Query.Risk
                .View(RiskView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectProjects(new ProjectQuery()
                    .SelectAll())
                .SelectServices(new ServiceQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(risks);
            Console.WriteLine($"Count: {risks.Count}");

            if (risks.Any())
            {
                risks = client.Get(new RiskQuery(risks.First().ID)).Result;
                Assert.IsNotNull(risks);
            }
        }
    }
}
