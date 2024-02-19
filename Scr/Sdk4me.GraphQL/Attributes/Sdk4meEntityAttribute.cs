namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Instruct the <see cref="Sdk4meClient"/> to use ignore the <see cref="Node.ID"/> property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class Sdk4meEntityAttribute : Attribute
    {
        /// <summary>
        /// Returns true when the query should exclude the default identifier property.
        /// </summary>
        public bool IgnoreIdentifier { get; set; } = false;


        /// <summary>
        /// Create a new instance of the <see cref="Sdk4meFieldAttribute"/> class.
        /// </summary>
        public Sdk4meEntityAttribute()
        {
        }

        /// <summary>
        /// Create a new instance of the <see cref="Sdk4meFieldAttribute"/> class.
        /// <param name="ignoreIdentifier">True when the query should ignore the default identifier property; otherwise false.</param>
        /// </summary>
        public Sdk4meEntityAttribute(bool ignoreIdentifier)
        {
            IgnoreIdentifier = ignoreIdentifier;
        }
    }
}
