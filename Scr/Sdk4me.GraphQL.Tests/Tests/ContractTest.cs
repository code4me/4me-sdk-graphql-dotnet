using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ContractTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Contract> contracts = client.Get(Query.Contract
                .View(ContractView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(contracts);
            Console.WriteLine($"Count: {contracts.Count}");

            if (contracts.Any())
            {
                contracts = client.Get(new ContractQuery(contracts.First().ID)).Result;
                Assert.IsNotNull(contracts);
            }
        }
    }
}
