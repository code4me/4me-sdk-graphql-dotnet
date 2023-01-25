using System.Diagnostics.Contracts;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ConfigurationItemTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ConfigurationItem> configurationItems = client.Get(Query.ConfigurationItem
                .View(ConfigurationItemView.All)
                .SelectAll()
                .SelectCiRelations(new ConfigurationItemRelationQuery()
                    .SelectAll())
                .SelectContracts(new ContractQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectLicensedSites(new SiteQuery()
                    .SelectAll())
                .SelectProblems(new ProblemQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectUsers(new PersonQuery())
                    .SelectAll()
                ).Result;

            Assert.IsNotNull(configurationItems);
            Console.WriteLine($"Count: {configurationItems.Count}");
        }
    }
}
