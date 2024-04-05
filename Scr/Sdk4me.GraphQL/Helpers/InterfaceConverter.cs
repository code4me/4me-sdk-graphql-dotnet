namespace Sdk4me.GraphQL
{
    /// <summary>
    /// An 4me GraphQL JSON interface converter.
    /// </summary>
    internal class InterfaceConverter : JsonConverter
    {
        private Dictionary<string, Type> interfaceTypeMappings = new();

        /// <summary>
        /// A collection of GraphQL types to Sdk4me data types to convert interface properties.
        /// </summary>
        public Dictionary<string, Type> InterfaceTypeMappings
        {
            get => interfaceTypeMappings;
            set => interfaceTypeMappings = value;
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>True if this instance can convert the specified object type; otherwise, false.</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsInterface;
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            JObject jsonObject = JObject.Load(reader);
            if (jsonObject.TryGetValue("__typename", out JToken? typeJtoken) && typeJtoken.Value<string>() is string typeName && !string.IsNullOrEmpty(typeName))
            {
                if (interfaceTypeMappings.TryGetValue(typeName, out Type? type) && type != null)
                {
                    return jsonObject.ToObject(type, serializer);
                }
            }
            else
            {
                throw new Sdk4meException($"The GraphQL __typename value for property of the type {objectType.Name} is null and cannot be casted to a known data type.");
            }
            return null;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
