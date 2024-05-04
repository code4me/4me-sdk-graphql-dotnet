﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class WorkflowTypeTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<WorkflowType> workflowTypes = client.Get(Query.WorkflowType
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(workflowTypes);
            Console.WriteLine($"Count: {workflowTypes.Count}");

            if (workflowTypes.Any())
            {
                workflowTypes = client.Get(new WorkflowTypeQuery(workflowTypes.First().ID)).Result;
                Assert.IsNotNull(workflowTypes);
            }
        }
    }
}
