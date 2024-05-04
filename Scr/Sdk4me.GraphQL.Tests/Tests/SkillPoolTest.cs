using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class SkillPoolTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<SkillPool> skillPools = client.Get(Query.SkillPool
                .View(SkillPoolView.All)
                .SelectAll()
                .SelectEffortClasses(new EffortClassQuery()
                    .SelectAll())
                .SelectMembers(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(skillPools);
            Console.WriteLine($"Count: {skillPools.Count}");

            if (skillPools.Any())
            {
                skillPools = client.Get(new SkillPoolQuery(skillPools.First().ID)).Result;
                Assert.IsNotNull(skillPools);
            }
        }
    }
}
