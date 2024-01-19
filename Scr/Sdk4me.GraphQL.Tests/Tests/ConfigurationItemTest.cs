using System.Diagnostics.Contracts;
using System.Globalization;

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

            if (configurationItems.Any())
            {
                configurationItems = client.Get(new ConfigurationItemQuery(configurationItems.First().ID)).Result;
                Assert.IsNotNull(configurationItems);
            }
        }

        [TestMethod]
        public void GetUsingLevel2Pagination()
        {
            ConfigurationItem? configurationItem = client.Get(new ConfigurationItemQuery("NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9DaS8xOTk4")
                .Select(ConfigurationItemField.ID, ConfigurationItemField.Label, ConfigurationItemField.Name)
                .SelectCiRelations(new ConfigurationItemRelationQuery()
                    .ItemsPerRequest(5)
                    .SelectAll())
                ).Result.FirstOrDefault();

            Assert.IsNotNull(configurationItem);
            Assert.IsTrue(configurationItem.CiRelations?.Count == 37);

            ConfigurationItemRelation first = configurationItem.CiRelations.First();
            Assert.IsTrue(first.ID == "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9DaVJlbGF0aW9uLzk4Mg");
            Assert.IsTrue(first.ConfigurationItem?.ID == "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9DaS8zMA");
            
            ConfigurationItemRelation last = configurationItem.CiRelations.Last();
            Assert.IsTrue(last.ID == "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9DaVJlbGF0aW9uLzEwNTQ");
            Assert.IsTrue(last.ConfigurationItem?.ID == "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9DaS8xODM");
        }
    }
}
