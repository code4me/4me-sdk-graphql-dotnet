using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// An 4me GraphQL ISO8601Time <see cref="JsonConverter"/>.
    /// </summary>
    public class ISO8601TimeJsonConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns> True if this instance can convert the specified object type; otherwise, false.</returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(objectType) ?? throw new ArgumentNullException(nameof(objectType)) : objectType) == typeof(TimeSpan);
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
                if (value.Split(':') is string[] values && values.Length == 2)
                {
                    if (int.TryParse(values[0], out int hours) && int.TryParse(values[1], out int minutes))
                        return new TimeSpan().Add(TimeSpan.FromHours(hours)).Add(TimeSpan.FromMinutes(minutes));
                }
                else
                {
                    TimeSpan.Parse(value);
                }
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
            if (value is TimeSpan timeSpan)
                writer.WriteValue($"{Math.Floor(timeSpan.TotalHours):00}:{timeSpan.Minutes:00}");
            writer.WriteValue(value);
        }
    }
}
