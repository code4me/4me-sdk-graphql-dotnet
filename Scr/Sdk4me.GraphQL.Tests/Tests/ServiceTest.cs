using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ServiceTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Service> services = client.Get(Query.Service
                .View(ServiceView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectServiceLevelAgreements(new ServiceLevelAgreementQuery()
                    .SelectAll())
                .SelectServiceOfferings(new ServiceOfferingQuery()
                    .SelectAll())   
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(services);
            Console.WriteLine($"Count: {services.Count}");

            if (services.Any())
            {
                services = client.Get(new ServiceQuery(services.First().ID)).Result;
                Assert.IsNotNull(services);
            }
        }
    }
}
