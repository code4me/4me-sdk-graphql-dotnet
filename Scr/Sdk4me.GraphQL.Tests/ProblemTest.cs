namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProblemTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Problem> problems = client.Get(Query.Problem
                .View(ProblemView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll())
                .SelectTimeEntries(new TimeEntryQuery()
                    .SelectAll())
                .SelectWorkaroundAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(problems);
            Console.WriteLine($"Count: {problems.Count}");

            if (problems.Any())
            {
                problems = client.Get(new ProblemQuery(problems.First().ID)).Result;
                Assert.IsNotNull(problems);
            }
        }
    }
}
