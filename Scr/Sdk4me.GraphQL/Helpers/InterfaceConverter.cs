using System.Text.RegularExpressions;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// An <see cref="IHasTranslations"/> JSON converter.
    /// </summary>
    internal class InterfaceConverter : JsonConverter
    {
        private List<ExecutionQuery> onTypeQueries = new();

        /// <summary>
        /// Get or set the OnType queries values to properly initialize a new instance of interface compatible type.
        /// </summary>
        public List<ExecutionQuery> OnTypeQueries
        {
            get => onTypeQueries;
            set => onTypeQueries = value;
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>True if this instance can convert the specified object type; otherwise, false.</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IHasAutomationRules)
                || objectType == typeof(IHasLifeCycleState)
                || objectType == typeof(IHasNotes)
                || objectType == typeof(IHasSprintBacklogItems)
                || objectType == typeof(IHasTimeEntries)
                || objectType == typeof(IHasTranslations);
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
            {
                return null;
            }
            else 
            {
                JObject jsonObject = JObject.Load(reader);
                if (jsonObject.HasValues)
                {
                    string[] type = reader.Path.Split(".").Skip(2).ToArray().Where(item => !Regex.IsMatch(item, @"nodes\[\d+\]")).ToArray();

                    if (type.Length > 0 && onTypeQueries.Where(x => x.Depth == type.Length && x.FieldName == type[^1]).FirstOrDefault() is ExecutionQuery query && query != null)
                        return jsonObject.HasValues ? jsonObject.ToObject(query.DataType, serializer) : null;
                    throw new Sdk4meException($"The type, {objectType.Name}, is an interface or abstract class and cannot be instantiated.");
                }
                return null;
            }
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
