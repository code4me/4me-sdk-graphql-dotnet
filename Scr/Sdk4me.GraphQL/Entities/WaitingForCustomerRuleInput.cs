using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/waitingforcustomerruleinput/">WaitingForCustomerRuleInput</see> object.
    /// </summary>
    public class WaitingForCustomerRuleInput : PropertyChangeSet
    {
        private string? id;
        private long? nrOfBusinessDays;

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
        /// Notify the requester after the request has been waiting for a customer for this number of business days.
        /// </summary>
        [JsonProperty("nrOfBusinessDays")]
        public long? NrOfBusinessDays
        {
            get => nrOfBusinessDays;
            set => nrOfBusinessDays = Set("nrOfBusinessDays", value);
        }
    }
}
