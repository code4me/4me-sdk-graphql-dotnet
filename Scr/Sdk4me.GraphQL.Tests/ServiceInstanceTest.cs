namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ServiceInstanceTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ServiceInstance> serviceInstances = client.Get(Query.ServiceInstance
                .View(ServiceInstanceView.All)
                .SelectAll()
                .SelectChildServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectParentServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(serviceInstances);
            Console.WriteLine($"Count: {serviceInstances.Count}");
        }
    }
}
