using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of <see cref="Enum"/> extension methods.
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Returns the <see cref="EnumMemberAttribute"/> of an enumerator.
        /// </summary>
        /// <param name="value">The enumerator value.</param>
        /// <returns>The enumerator attribute value; or the name if the value is <c>null</c>.</returns>
        public static string GetEnumMemberValue(this Enum value)
        {
            return value.GetType().GetMember(value.ToString()).FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault()?.Value ?? value.ToString();
        }
    }
}
