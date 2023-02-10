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
                    .SelectAll())
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll())
                .SelectTimeEntries(new TimeEntryQuery()
                    .SelectAll())
                .SelectWatches(new WatchQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(requests);
            Console.WriteLine($"Count: {requests.Count}");
        }
    }
}
