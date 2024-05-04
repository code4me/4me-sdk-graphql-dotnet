using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class RequestTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Request> requests = client.Get(Query.Request
                .View(RequestView.All)
                .ItemsPerRequest(1)
                .SelectAll()
                .SelectAffectedSlas(new AffectedSlaQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectGroupedRequests(new RequestQuery()
                    .SelectAll())
                .SelectKnowledgeArticles(new KnowledgeArticleQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll()
                    .SelectNoteReactions(new NoteReactionQuery()
                        .ItemsPerRequest(1)
                        .SelectAll()))
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll())
                .SelectTimeEntries(new TimeEntryQuery()
                    .SelectAll())
                .SelectWatches(new WatchQuery()
                    .SelectAll())
                .SelectTags(new TagQuery()
                    .ItemsPerRequest(5)
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(requests);
            Console.WriteLine($"Count: {requests.Count}");

            if (requests.Any())
            {
                requests = client.Get(new RequestQuery(requests.First().ID)
                    .Select(RequestField.RequestId)).Result;
                Assert.IsNotNull(requests);
                Request request = requests.First();
                Assert.IsTrue(request.GetIdentifier() > 0);
                Assert.IsTrue(request.GetIdentifier() == Convert.ToInt64(request.RequestId));
            }
        }
    }
}
