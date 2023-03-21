namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/effortclasschargeidinput/">EffortClassChargeIDInput</see> object.
    /// </summary>
    public class EffortClassChargeIDInput : PropertyChangeSet
    {
        private string? id;
        private string? effortClassId;
        private string? chargeID;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The effort class ID for which a billing identifier is provided.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("chargeID")]
        public string? ChargeID
        {
            get => chargeID;
            set => chargeID = Set("chargeID", value);
        }
    }
}
