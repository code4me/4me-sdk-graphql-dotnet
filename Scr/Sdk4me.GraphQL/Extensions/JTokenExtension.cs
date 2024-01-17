using System.Globalization;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of <see cref="JToken"/> extension methods.
    /// </summary>
    public static class JTokenExtension
    {
        /// <summary>
        /// Convert all <see cref="JToken"/> property names from snake case to camel case.
        /// </summary>
        /// <param name="token">The <see cref="JToken"/> object.</param>
        /// <returns>A new instance of the <see cref="JToken"/> with new camel case property names.</returns>
        public static JToken ToCamelCaseJToken(this JToken token)
        {
            return token.Type switch
            {
                JTokenType.Object => ((JObject)token).ToCamelCaseJObject(),
                JTokenType.Array => new JArray(((JArray)token).Select(x => x.ToCamelCaseJToken())),
                _ => token.DeepClone(),
            };
        }

        /// <summary>
        /// Convert all <see cref="JObject"/> property names from snake case to camel case.
        /// </summary>
        /// <param name="token">The <see cref="JObject"/> object.</param>
        /// <returns>A new instance of the <see cref="JObject"/> with new camel case property names.</returns>
        public static JObject ToCamelCaseJObject(this JObject token)
        {
            JObject retval = new();

            foreach (JProperty property in token.Properties())
            {
                if (property.Name == "id" && property.Value.Type == JTokenType.String)
                {
                    retval["id"] = property.Value;
                }
                else
                {
                    if (!property.Name.Equals("id"))
                    {
                        if (property.Name.Equals("nodeID"))
                            retval["id"] = property.Value.ToCamelCaseJToken();
                        else
                            retval[ConvertSnakeCaseToCamelCase(property.Name)] = property.Value.ToCamelCaseJToken();
                    }
                }
            }
            return retval;
        }

        /// <summary>
        /// Convert a snake case variable name to camel case.
        /// </summary>
        /// <param name="text">The snake case value.</param>
        /// <returns>A camel case version of the snake case value.</returns>
        private static string ConvertSnakeCaseToCamelCase(string text)
        {
            string[] items = text.Split('_');
            for (int i = 1; i <= items.GetUpperBound(0); i++)
                items[i] = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(items[i]);
            return string.Concat(items);
        }
    }
}
