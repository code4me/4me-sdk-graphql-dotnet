using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TranslationTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Translation> translations = client.Get(Query.Translation
                .View(TranslationView.CurrentAccount)
                .SelectAll()
                .SelectOwner(new ServiceQuery()
                    .ItemsPerRequest(1)
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(translations);
            Console.WriteLine($"Count: {translations.Count}");

            if (translations.Any())
            {
                translations = client.Get(new TranslationQuery(translations.First().ID)).Result;
                Assert.IsNotNull(translations);
            }
        }
    }
}
