using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class SurveyTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Survey> surveys = client.Get(Query.Survey
                .View(SurveyView.All)
                .SelectAll()
                .SelectCompletionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectCompletionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectIntroductionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectQuestions(new SurveyQuestionQuery()
                    .ItemsPerRequest(10)
                    .SelectTranslations(new TranslationQuery()
                        .ItemsPerRequest(1)
                        .SelectAll())
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .ItemsPerRequest(1)
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(surveys);
            Console.WriteLine($"Count: {surveys.Count}");

            if (surveys.Any())
            {
                surveys = client.Get(new SurveyQuery(surveys.First().ID)).Result;
                Assert.IsNotNull(surveys);
            }
        }
    }
}
