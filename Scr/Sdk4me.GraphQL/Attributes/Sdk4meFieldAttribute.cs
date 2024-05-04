using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Instruct the <see cref="Sdk4meClient"/> to use this as a default property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class Sdk4meFieldAttribute : Attribute
    {
        /// <summary>
        /// Returns true when it is a default property.
        /// </summary>
        public bool IsDefault { get; } = false;

        /// <summary>
        /// Create a new instance of the <see cref="Sdk4meFieldAttribute"/> class.
        /// </summary>
        /// <param name="isDefault">True when it is a default property; otherwise false.</param>
        public Sdk4meFieldAttribute(bool isDefault)
        {
            IsDefault = isDefault;
        }
    }
}
