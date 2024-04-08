using System.Text;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of <see cref="string"/> extension methods.
    /// </summary>
    internal static class StringExtension
    {
        /// <summary>
        /// Extract the object type name from a GraphQL identifier.
        /// </summary>
        /// <param name="id">The GraphQL identifier.</param>
        /// <returns>The object type name, or <see cref="string.Empty"/> if the system was unable extract the object type name.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static string Get4meIdentifierObjectType(this string id)
        {
            string[] data = (id.Length % 4) switch
            {
                0 => Encoding.UTF8.GetString(Convert.FromBase64String(id)).Split('/'),
                2 => Encoding.UTF8.GetString(Convert.FromBase64String(id + "==")).Split('/'),
                3 => Encoding.UTF8.GetString(Convert.FromBase64String(id + "=")).Split('/'),
                _ => throw new Sdk4meException("Unsupported identifier value.")
            };
            return data.Length == 3 ? data[1] : string.Empty;
        }


        /// <summary>
        /// Extract the REST API numerical identifier from a GraphQL identifier.
        /// </summary>
        /// <param name="id">The GraphQL identifier.</param>
        /// <returns>The object type name, or <see cref="string.Empty"/> if the system was unable extract the object type name.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static long Get4meIdentifier(this string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return 0;

            id = (id.Length % 4) switch
            {
                0 => Encoding.UTF8.GetString(Convert.FromBase64String(id)),
                2 => Encoding.UTF8.GetString(Convert.FromBase64String(id + "==")),
                3 => Encoding.UTF8.GetString(Convert.FromBase64String(id + "=")),
                _ => throw new Sdk4meException("Unsupported identifier value."),
            };

            if (long.TryParse(id.Split('/')[^1], out long result))
                return result;

            return 0;
        }
    }
}
