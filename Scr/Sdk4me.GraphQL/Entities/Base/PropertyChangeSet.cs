using System.Collections.Generic;
using System.Collections.Immutable;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The 4me object item property change collection.
    /// </summary>
    public class PropertyChangeSet
    {
        private readonly HashSet<string> fields = new();

        /// <summary>
        /// The field collection.
        /// </summary>
        internal protected HashSet<string> Fields
        {
            get => fields;
        }

        /// <summary>
        /// Stores the name in the field collection.
        /// </summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        /// <returns>The property value.</returns>
        internal protected T Set<T>(string name, T value)
        {
            fields.Add(name);
            return value;
        }

        /// <summary>
        /// Get all changed field names.
        /// </summary>
        /// <returns>A list of changed field names.</returns>
        public ImmutableHashSet<string> GetFields()
        {
            return fields.ToImmutableHashSet();
        }
    }
}
