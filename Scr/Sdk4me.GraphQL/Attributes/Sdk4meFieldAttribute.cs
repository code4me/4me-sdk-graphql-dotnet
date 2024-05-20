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
        /// Indicates if this is a default property.
        /// </summary>
        public bool IsDefaultQueryProperty { get; set; } = false;

        /// <summary>
        /// Indicates if this field is required in a mutation.
        /// </summary>
        public bool IsRequiredForMutation { get; set; } = false;

        /// <summary>
        /// Create a new instance of the <see cref="Sdk4meFieldAttribute"/> class.
        /// </summary>
        public Sdk4meFieldAttribute()
        {
        }
    }
}
