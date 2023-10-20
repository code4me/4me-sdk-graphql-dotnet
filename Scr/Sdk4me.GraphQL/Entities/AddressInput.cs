namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/addressinput/">AddressInput</see> object.
    /// </summary>
    public class AddressInput : PropertyChangeSet
    {
        private string? city;
        private string? country;
        private string? id;
        private bool? integration;
        private AddressLabel? label;
        private string? state;
        private string? address;
        private string? zip;

        /// <summary>
        /// The city name.
        /// </summary>
        [JsonProperty("city")]
        public string? City
        {
            get => city;
            set => city = Set("city", value);
        }

        /// <summary>
        /// The city name.
        /// </summary>
        [JsonProperty("country")]
        public string? Country
        {
            get => country;
            set => country = Set("country", value);
        }

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
        /// The Integration field is a hidden checkbox that can be set to <c>true</c> using this API or the Import functionality. When checked, the address is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [JsonProperty("integration")]
        public bool? Integration
        {
            get => integration;
            set => integration = Set("integration", value);
        }

        /// <summary>
        /// The Label of the address details.
        /// </summary>
        [JsonProperty("label")]
        public AddressLabel? Label
        {
            get => label;
            set => label = Set("label", value);
        }

        /// <summary>
        /// The state name.
        /// </summary>
        [JsonProperty("state")]
        public string? State
        {
            get => state;
            set => state = Set("state", value);
        }

        /// <summary>
        /// The address lines.
        /// </summary>
        [JsonProperty("address")]
        public string? Street
        {
            get => address;
            set => address = Set("address", value);
        }

        /// <summary>
        /// The zip code.
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip
        {
            get => zip;
            set => zip = Set("zip", value);
        }

        /// <summary>
        /// Returns an <see cref="AddressInput"/> instance of an <see cref="Address"/>.
        /// </summary>
        public static implicit operator AddressInput(Address input)
        {
            return new AddressInput()
            {
                City = input.City,
                Country = input.Country,
                ID = input.ID,
                Integration = input.Integration,
                Label = input.Label,
                State = input.State,
                Street = input.Street,
                Zip = input.Zip,
            };
        }
    }
}
