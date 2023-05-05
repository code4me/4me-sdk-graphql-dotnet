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
                .ItemsPerRequest(10)
                .SelectAll()
                .SelectChildServiceInstances(new ServiceInstanceQuery())
                .SelectConfigurationItems(new ConfigurationItemQuery())
                .SelectCustomFieldsAttachments(new AttachmentQuery())
                .SelectParentServiceInstances(new ServiceInstanceQuery())
                .SelectRemarksAttachments(new AttachmentQuery())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery())
                .SelectTranslations(new TranslationQuery())
                ).Result;

            Assert.IsNotNull(serviceInstances);
            Console.WriteLine($"Count: {serviceInstances.Count}");
        }
    }
}
