using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class SyncSetTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<SyncSet> syncSets = client.Get(Query.SyncSet
                .View(DefaultView.None)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectSelectedRecords(new RecordQuery()
                    .SelectAll())
                .SelectLastSnapshot(new SnapshotQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(syncSets);
            Console.WriteLine($"Count: {syncSets.Count}");

            if (syncSets.Any())
            {
                syncSets = client.Get(new SyncSetQuery(syncSets.First().ID)).Result;
                Assert.IsNotNull(syncSets);
            }
        }
    }
}
