﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class AppInstanceTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<AppInstance> appInstances = client.Get(Query.AppInstance
                .View(AppInstanceView.All)
                .SelectAll()
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(appInstances);
            Console.WriteLine($"Count: {appInstances.Count}");

            if (appInstances.Any())
            {
                appInstances = client.Get(new AppInstanceQuery(appInstances.First().ID)).Result;
                Assert.IsNotNull(appInstances);
            }
        }
    }
}
