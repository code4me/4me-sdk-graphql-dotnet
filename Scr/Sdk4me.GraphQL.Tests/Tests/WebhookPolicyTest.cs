using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class WebhookPolicyTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<WebhookPolicy> webhookPolicies = client.Get(Query.WebhookPolicy
                .View(DefaultView.None)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(webhookPolicies);
            Console.WriteLine($"Count: {webhookPolicies.Count}");

            if (webhookPolicies.Any())
            {
                webhookPolicies = client.Get(new WebhookPolicyQuery(webhookPolicies.First().ID)).Result;
                Assert.IsNotNull(webhookPolicies);
            }
        }

        [TestMethod]
        public void Create()
        {
            WebhookPolicyCreatePayload webhookPolicyCreatePayload = client.Mutation(
                new WebhookPolicyCreateInput(WebhookPolicyJwtAlg.Rs512) { Disabled = false, ClientMutationId = "CMID" }, 
                new WebhookPolicyCreateResponseQuery().Select(WebhookPolicyCreateResponseField.ID, WebhookPolicyCreateResponseField.PublicKeyPem)
                ).Result;

            Assert.IsNotNull(webhookPolicyCreatePayload);
            Assert.IsNotNull(webhookPolicyCreatePayload.WebhookPolicy);
            Assert.IsFalse(string.IsNullOrWhiteSpace(webhookPolicyCreatePayload.WebhookPolicy.PublicKeyPem));

            WebhookPolicyDeleteMutationPayload webhookPolicyDeleteMutationPayload = client.Mutation(new WebhookPolicyDeleteMutationInput(webhookPolicyCreatePayload.WebhookPolicy.ID)).Result;
            Assert.IsNotNull(webhookPolicyDeleteMutationPayload);
        }
    }
}
