using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class AttachmentStorageTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<AttachmentStorage> attachmentStorages = client.Get(Query.AttachmentStorage
                .View(DefaultView.None)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(attachmentStorages);
            Assert.IsTrue(attachmentStorages.Count == 1);
        }
    }
}
