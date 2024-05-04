using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class BroadcastTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Broadcast> broadcasts = client.Get(Query.Broadcast
                .View(DefaultView.None)
                .SelectAll()
                .SelectCustomers(new OrganizationQuery()
                    .ItemsPerRequest(10)
                    .SelectAll()
                    .SelectAddresses(new AddressQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectChildOrganizations(new OrganizationQuery()
                    .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectContacts(new ContactQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectCustomFieldsAttachments(new AttachmentQuery()
                        .ItemsPerRequest(10)
                        .SelectAll()))
                    .SelectRemarksAttachments(new AttachmentQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectTranslations(new BroadcastTranslationQuery()
                        .ItemsPerRequest(1))
                ).Result;

            Assert.IsNotNull(broadcasts);
            Console.WriteLine($"Count: {broadcasts.Count}");

            if (broadcasts.Any())
            {
                broadcasts = client.Get(new BroadcastQuery(broadcasts.First().ID)).Result;
                Assert.IsNotNull(broadcasts);
            }
        }

        [TestMethod]
        public void Create()
        {
            BroadcastCreatePayload broadcast = client.Mutation(new BroadcastCreateInput()
            {
                Message = $"Sdk4me.GraphQL {DateTime.Now:yyyy-MM-dd HH:mm:ss} UTC",
                Remarks = $"Sdk4me.GraphQL Test {DateTime.Now:yyyy-MM-dd HH:mm:ss} UTC",
                MessageType = BroadcastMessageType.Info,
                Source = "Sdk4me",
                Visibility = BroadcastVisibility.OrganizationsAndDescendants,
                StartAt = DateTime.Now.AddSeconds(5),
                EndAt = DateTime.Now.AddMinutes(1),
                OrganizationIds = new() { "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9Pcmdhbml6YXRpb24vNg" }
            }, new BroadcastQuery().Select(BroadcastField.ID, BroadcastField.Remarks, BroadcastField.Organizations)).Result;

            Assert.IsNotNull(broadcast);
            Assert.IsNotNull(broadcast.Broadcast?.ID);
            Assert.IsNotNull(broadcast.Broadcast?.Remarks);
            Assert.IsNotNull(broadcast.Broadcast?.Organizations);
            Assert.IsInstanceOfType(broadcast.Broadcast?.Organizations, typeof(DataList<Organization>));
            Assert.IsTrue(broadcast.Broadcast?.Organizations.Count > 0);
        }

        [TestMethod]
        public void Update()
        {
            DataList<Broadcast> broadcasts = client.Get(Query.Broadcast
                .View(DefaultView.None)
                .Select(BroadcastField.ID, BroadcastField.MessageType, BroadcastField.Remarks)).Result;

            if (broadcasts.Where(x => x.Remarks != null && x.Remarks.StartsWith("Sdk4me.GraphQL")).FirstOrDefault() is Broadcast broadcast)
            {
                BroadcastUpdatePayload broadcastUpdate = client.Mutation(new BroadcastUpdateInput() 
                {
                    ID = broadcast.ID,
                    Remarks = $"Sdk4me.GraphQL {DateTime.Now:yyyy-MM-dd HH:mm:ss} UTC",
                    Message = $"Sdk4me.GraphQL {DateTime.Now:yyyy-MM-dd HH:mm:ss} UTC",
                    StartAt = broadcast.StartAt ?? DateTime.Now.AddSeconds(5),
                    EndAt = DateTime.Now.AddSeconds(10),
                }, new BroadcastQuery().Select(BroadcastField.ID, BroadcastField.Remarks, BroadcastField.Organizations)).Result;

                Assert.IsNotNull(broadcastUpdate); 
                Assert.IsNotNull(broadcastUpdate.Broadcast?.ID);
                Assert.IsNotNull(broadcastUpdate.Broadcast?.Remarks);
                Assert.IsNotNull(broadcastUpdate.Broadcast?.Organizations);
                Assert.IsInstanceOfType(broadcastUpdate.Broadcast?.Organizations, typeof(DataList<Organization>));
                Assert.IsTrue(broadcastUpdate.Broadcast?.Organizations.Count > 0);
            }
        }
    }
}
