namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ServiceLevelAgreementTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ServiceLevelAgreement> serviceLevelAgreements = client.Get(Query.ServiceLevelAgreement
                .View(ServiceLevelAgreementView.All)
                .SelectAll()
                .SelectCustomerRepresentatives(new PersonQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectPeople(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceInstances(new ParentServiceInstanceQuery()
                    .SelectAll())
                .SelectSites(new SiteQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(serviceLevelAgreements);
            Console.WriteLine($"Count: {serviceLevelAgreements.Count}");
        }
    }
}
