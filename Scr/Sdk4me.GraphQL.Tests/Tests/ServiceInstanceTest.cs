using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

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
                .SelectTranslations(new TranslationQuery()
                    .SelectOwner(new ServiceQuery()
                        .Select(ServiceField.ID))
                    .SelectOwner(new ServiceInstanceQuery()
                        .Select(ServiceInstanceField.ID)))
                ).Result;

            Assert.IsNotNull(serviceInstances);
            Console.WriteLine($"Count: {serviceInstances.Count}");

            if (serviceInstances.Any())
            {
                serviceInstances = client.Get(new ServiceInstanceQuery(serviceInstances.First().ID)).Result;
                Assert.IsNotNull(serviceInstances);
            }
        }
    }
}
