namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ServiceOfferingTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ServiceOffering> serviceOfferings = client.Get(Query.ServiceOffering
                .View(ServiceOfferingView.All)
                .SelectAll()
                .SelectChargesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectContinuityAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectEffortClasses(new EffortClassQuery()
                    .SelectAll())
                .SelectEffortClassRates(new EffortClassRateQuery()
                    .SelectAll())
                .SelectLimitationsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPenaltiesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPerformanceAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPrerequisitesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery()
                    .SelectAll())
                .SelectShopArticles(new ShopArticleQuery()
                    .SelectAll())
                .SelectStandardServiceRequests(new StandardServiceRequestQuery()
                    .SelectAll())
                .SelectSummaryAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTerminationAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(serviceOfferings);
            Console.WriteLine($"Count: {serviceOfferings.Count}");
        }
    }
}
