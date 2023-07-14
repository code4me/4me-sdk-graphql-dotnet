namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProjectTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Project> projects = client.Get(Query.Project
                .View(ProjectView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectPhases(new ProjectPhaseQuery()
                    .SelectAll())
                .SelectProblems(new ProblemQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectRisks(new RiskQuery()
                    .SelectAll())
                .SelectTasks(new ProjectTaskQuery()
                    .SelectAll())
                .SelectWorkflows(new WorkflowQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(projects);
            Console.WriteLine($"Count: {projects.Count}");

            if (projects.Any())
            {
                projects = client.Get(new ProjectQuery(projects.First().ID)).Result;
                Assert.IsNotNull(projects);
            }
        }
    }
}
