using System;
using System.Text;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of <see cref="string"/> extension methods for extracting information from GraphQL identifiers.
    /// </summary>
    public static class NodeExtension
    {
        /// <summary>
        /// Extracts the 4me instance identifier from a GraphQL identifier.
        /// </summary>
        /// <param name="node">An <see cref="Node"/> object containing the GraphQL identifier.</param>
        /// <returns>The 4me instance identifier extracted from the GraphQL identifier.</returns>
        /// <exception cref="Sdk4meException">Thrown when the identifier is not supported or invalid.</exception>
        internal static string GetInstance(this Node node)
        {
            string[] data = FromBase64(node.ID);
            return data[0];
        }

        /// <summary>
        /// Extracts the object type name from a GraphQL identifier.
        /// </summary>
        /// <param name="node">An <see cref="Node"/> object containing the GraphQL identifier.</param>
        /// <returns>The object type name extracted from the GraphQL identifier.</returns>
        /// <exception cref="Sdk4meException">Thrown when the identifier is not supported or invalid.</exception>
        internal static string GetObjectType(this Node node)
        {
            string[] data = FromBase64(node.ID);
            return data[1];
        }

        /// <summary>
        /// Extracts the REST API numerical identifier from a GraphQL identifier.
        /// </summary>
        /// <param name="node">An <see cref="Node"/> object containing the GraphQL identifier.</param>
        /// <returns>The REST API numerical identifier extracted from the GraphQL identifier.</returns>
        /// <exception cref="Sdk4meException">Thrown when the identifier is not supported or invalid.</exception>
        public static long GetIdentifier(this Node node)
        {
            string[] data = FromBase64(node.ID);
            if (long.TryParse(data[2], out long result))
                return result;
            return 0;
        }

        /// <summary>
        /// Decodes a Base64 encoded GraphQL identifier and splits it into its components.
        /// </summary>
        /// <param name="identifier">The Base64 encoded GraphQL identifier.</param>
        /// <returns>An array of strings containing the components of the identifier.</returns>
        /// <exception cref="Sdk4meException">Thrown when the identifier is not supported or invalid.</exception>
        private static string[] FromBase64(string identifier)
        {
            string[] retval = (identifier.Length % 4) switch
            {
                0 => Encoding.UTF8.GetString(Convert.FromBase64String(identifier)).Split('/'),
                2 => Encoding.UTF8.GetString(Convert.FromBase64String(identifier + "==")).Split('/'),
                3 => Encoding.UTF8.GetString(Convert.FromBase64String(identifier + "=")).Split('/'),
                _ => throw new Sdk4meException("Unsupported GraphQL or nodeID value.")
            };

            if (retval.Length != 3)
                throw new Sdk4meException("Unsupported GraphQL or nodeID value.");

            return retval;
        }
    }
}
