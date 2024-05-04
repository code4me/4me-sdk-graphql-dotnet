using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class CustomCollectionElementTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<CustomCollectionElement> customCollectionElements = client.Get(Query.CustomCollectionElement
                .View(CustomCollectionElementView.All)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(customCollectionElements);
            Console.WriteLine($"Count: {customCollectionElements.Count}");

            if (customCollectionElements.Any())
            {
                customCollectionElements = client.Get(new CustomCollectionElementQuery(customCollectionElements.First().ID)).Result;
                Assert.IsNotNull(customCollectionElements);
            }
        }
    }
}
