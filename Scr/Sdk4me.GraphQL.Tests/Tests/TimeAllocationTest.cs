﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TimeAllocationTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<TimeAllocation> timeAllocations = client.Get(Query.TimeAllocation
                .View(TimeAllocationView.All)
                .SelectAll()
                .SelectCustomers(new OrganizationQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                .SelectServices(new ServiceQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(timeAllocations);
            Console.WriteLine($"Count: {timeAllocations.Count}");

            if (timeAllocations.Any())
            {
                timeAllocations = client.Get(new TimeAllocationQuery(timeAllocations.First().ID)).Result;
                Assert.IsNotNull(timeAllocations);
            }
        }
    }
}
