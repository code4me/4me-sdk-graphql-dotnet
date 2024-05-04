using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class AffectedSlaTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            client.MaximumRecursiveRequests = 1;

            DataList<AffectedSla> affectedSlas = client.Get(Query.AffectedSla
                .View(AffectedSlaView.All)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(affectedSlas);
            Console.WriteLine($"Count: {affectedSlas.Count}");

            AffectedSla affectedSla = affectedSlas.First();
            Assert.IsNotNull(affectedSla.ID);

            affectedSla = client.Get(new AffectedSlaQuery(affectedSla.ID)).Result.First();
            Assert.IsNotNull(affectedSla.ID);

            IEnumerable<AffectedSla> noTargets = affectedSlas.Where(x => x.NextTargetAt != null && x.NextTargetAt.Value.IsNoTarget());
            Console.WriteLine($"No target count: {noTargets.Count()}");
            Assert.IsNotNull(noTargets);

            IEnumerable<AffectedSla> clocksStopped = affectedSlas.Where(x => x.NextTargetAt != null && x.NextTargetAt.Value.IsClockStopped());
            Console.WriteLine($"Clock stopped count: {clocksStopped.Count()}");
            Assert.IsNotNull(clocksStopped);

            IEnumerable<AffectedSla> bestEfforts = affectedSlas.Where(x => x.NextTargetAt != null && x.NextTargetAt.Value.IsBestEffort());
            Console.WriteLine($"Best effort count: {bestEfforts.Count()}");
            Assert.IsNotNull(bestEfforts);
        }
    }
}
