using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ServiceCategoryTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ServiceCategory> serviceCategories = client.Get(Query.ServiceCategory
                .View(DefaultView.None)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServices(new ServiceQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new ServiceCategoryQuery()
                        .ItemsPerRequest(1)
                        .SelectAll()))
                ).Result;

            Assert.IsNotNull(serviceCategories);
            Console.WriteLine($"Count: {serviceCategories.Count}");

            if (serviceCategories.Any())
            {
                serviceCategories = client.Get(new ServiceCategoryQuery(serviceCategories.First().ID)).Result;
                Assert.IsNotNull(serviceCategories);
            }
        }
    }
}
