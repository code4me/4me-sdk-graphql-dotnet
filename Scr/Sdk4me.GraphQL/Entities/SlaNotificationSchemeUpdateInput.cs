using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/slanotificationschemeupdateinput/">SlaNotificationSchemeUpdateInput</see> object.
    /// </summary>
    public class SlaNotificationSchemeUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private bool? disabled;
        private string id;
        private string? name;
        private List<SlaNotificationRuleInput>? newSlaNotificationRules;
        private List<string>? slaNotificationRulesToDelete;
        private string? source;
        private string? sourceID;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Whether the SLA notification scheme may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The name of the SLA notification scheme.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Rules of this SLA notification scheme.
        /// </summary>
        [JsonProperty("newSlaNotificationRules")]
        public List<SlaNotificationRuleInput>? NewSlaNotificationRules
        {
            get => newSlaNotificationRules;
            set => newSlaNotificationRules = Set("newSlaNotificationRules", value);
        }

        /// <summary>
        /// Identifiers of rules to remove from the scheme.
        /// </summary>
        [JsonProperty("slaNotificationRulesToDelete")]
        public List<string>? SlaNotificationRulesToDelete
        {
            get => slaNotificationRulesToDelete;
            set => slaNotificationRulesToDelete = Set("slaNotificationRulesToDelete", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlaNotificationSchemeUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public SlaNotificationSchemeUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
