namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class WorkflowTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Workflow> workflows = client.Get(Query.Workflow
                .View(WorkflowView.All)
                .SelectAll()
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectPhases(new WorkflowPhaseQuery()
                    .SelectAll())
                .SelectProblems(new ProblemQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectTasks(new TaskQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(workflows);
            Console.WriteLine($"Count: {workflows.Count}");
        }
    }
}
