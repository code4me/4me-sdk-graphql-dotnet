using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class SurveyResponseTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<SurveyResponse> surveyResponses = client.Get(Query.SurveyResponse
                .View(SurveyResponseView.All)
                .SelectAll()
                .SelectAnswers(new SurveyAnswerQuery()
                    .SelectAll())
                .SelectSlas(new ServiceLevelAgreementQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(surveyResponses);
            Console.WriteLine($"Count: {surveyResponses.Count}");

            if (surveyResponses.Any())
            {
                surveyResponses = client.Get(new SurveyResponseQuery(surveyResponses.First().ID)).Result;
                Assert.IsNotNull(surveyResponses);
            }
        }
    }
}
