using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appofferingpublishmutationinput/">AppOfferingPublishMutationInput</see> object.
    /// </summary>
    public class AppOfferingPublishMutationInput : PropertyChangeSet
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
        /// Identifier of the draft app offering that should be copied to created a new published app offering version.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingPublishMutationInput"/> class without providing the required values.
        /// </summary>
        public AppOfferingPublishMutationInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingPublishMutationInput"/> class.
        /// </summary>
        /// <param name="id">Identifier of the draft app offering that should be copied to created a new published app offering version.</param>
        public AppOfferingPublishMutationInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
