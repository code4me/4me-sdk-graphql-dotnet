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
                .SelectEffortClassRateIDs(new EffortClassRateIDQuery()
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
                .SelectStandardServiceRequestActivityIDs(new StandardServiceRequestActivityIDQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(serviceLevelAgreements);
            Console.WriteLine($"Count: {serviceLevelAgreements.Count}");

            if (serviceLevelAgreements.Any())
            {
                serviceLevelAgreements = client.Get(new ServiceLevelAgreementQuery(serviceLevelAgreements.First().ID)).Result;
                Assert.IsNotNull(serviceLevelAgreements);
            }
        }
    }
}
