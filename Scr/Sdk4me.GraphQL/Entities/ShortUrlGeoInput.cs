using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shorturlgeoinput/">ShortUrlGeoInput</see> object.
    /// </summary>
    public class ShortUrlGeoInput : PropertyChangeSet
    {
        private string? latitude;
        private string? longitude;

        /// <summary>
        /// Latitude coordinate of the location.
        /// </summary>
        [JsonProperty("latitude")]
        public string? Latitude
        {
            get => latitude;
            set => latitude = Set("latitude", value);
        }

        /// <summary>
        /// Longitude coordinate of the location.
        /// </summary>
        [JsonProperty("longitude")]
        public string? Longitude
        {
            get => longitude;
            set => longitude = Set("longitude", value);
        }
    }
}
