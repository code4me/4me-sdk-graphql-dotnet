using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appofferingautomationruledeletemutationinput/">AppOfferingAutomationRuleDeleteMutationInput</see> object.
    /// </summary>
    public class AppOfferingAutomationRuleDeleteMutationInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string id;

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
        /// The node ID of the record to delete.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleDeleteMutationInput"/> class without providing the required values.
        /// </summary>
        public AppOfferingAutomationRuleDeleteMutationInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleDeleteMutationInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to delete.</param>
        public AppOfferingAutomationRuleDeleteMutationInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
