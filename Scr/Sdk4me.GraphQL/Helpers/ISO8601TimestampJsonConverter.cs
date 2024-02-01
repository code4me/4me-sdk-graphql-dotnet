namespace Sdk4me.GraphQL
{
    /// <summary>
    /// An 4me GraphQL ISO8601Timestamp <see cref="JsonConverter"/>.
    /// </summary>
    public class ISO8601TimestampJsonConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns> True if this instance can convert the specified object type; otherwise, false.</returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(objectType) ?? throw new ArgumentNullException(nameof(objectType)) : objectType) == typeof(DateTime);
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
            if (reader.Value is string value)
            {
                if (DateTime.TryParse(value, out DateTime dateTimeValue))
                {
                    return dateTimeValue;
                }
                else
                {
                    return value switch
                    {
                        "best_effort" => DateTimeValue.BestEffortDateTime,
                        "no_target" => DateTimeValue.NoTargetDateTime,
                        "clock_stopped" => DateTimeValue.ClockStoppedDateTime,
                        _ => null
                    };
                }
            }
            return reader.Value;
        }

        /// <summary>
        /// <br>Writes a <see cref="object"/> value.</br>
        /// <br>An error will raised if the value cannot be written as a single JSON token.</br>
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The <see cref="object"/> value to write.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is DateTime dateTime)
            {
                if (dateTime.IsBestEffort())
                    writer.WriteValue(DateTimeValue.BestEffortText);
                else if (dateTime.IsNoTarget())
                    writer.WriteValue(DateTimeValue.NoTargetText);
                else if (dateTime.IsClockStopped())
                    writer.WriteValue(DateTimeValue.ClockStoppedText);
                else
                    writer.WriteValue(value);
            }
            else 
            {
                writer.WriteValue(value);
            }
        }
    }
}
