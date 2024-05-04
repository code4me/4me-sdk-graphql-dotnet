using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class CustomCollectionTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<CustomCollection> customCollections = client.Get(Query.CustomCollection
                .View(DefaultView.None)
                .SelectAll()
                .SelectCollectionElements(new CustomCollectionElementQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(customCollections);
            Console.WriteLine($"Count: {customCollections.Count}");

            if (customCollections.Any())
            {
                customCollections = client.Get(new CustomCollectionQuery(customCollections.First().ID)).Result;
                Assert.IsNotNull(customCollections);
            }
        }
    }
}
