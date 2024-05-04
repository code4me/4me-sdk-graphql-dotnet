using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class OrganizationTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Organization> organizations = client.Get(Query.Organization
                .View(OrganizationView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectChildOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectContacts(new ContactQuery()
                    .SelectAll())
                .SelectContracts(new ContractQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery() 
                    .SelectAll())
                .SelectPeople(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRisks(new RiskQuery()
                    .SelectAll())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery()
                    .SelectAll())
                .SelectTimeAllocations(new TimeAllocationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(organizations);
            Console.WriteLine($"Count: {organizations.Count}");

            if (organizations.Any())
            {
                organizations = client.Get(new OrganizationQuery(organizations.First().ID)).Result;
                Assert.IsNotNull(organizations);
            }
        }
    }
}
