using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class RequestTemplateTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<RequestTemplate> requestTemplates = client.Get(Query.RequestTemplate
                .View(RequestTemplateView.All)
                .SelectAll()
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectRegistrationHintsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectReservationOfferings(new ReservationOfferingQuery()
                    .SelectAll())
                .SelectStandardServiceRequests(new StandardServiceRequestQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(requestTemplates);
            Console.WriteLine($"Count: {requestTemplates.Count}");

            if (requestTemplates.Any())
            {
                requestTemplates = client.Get(new RequestTemplateQuery(requestTemplates.First().ID)).Result;
                Assert.IsNotNull(requestTemplates);
            }
        }
    }
}
