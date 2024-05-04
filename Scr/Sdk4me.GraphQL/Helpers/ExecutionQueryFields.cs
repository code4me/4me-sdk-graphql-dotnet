using System.Collections.Generic;
using System.Reflection;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// An execution query field.
    /// </summary>
    internal sealed class ExecutionQueryField
    {
        /// <summary>
        /// The name.
        /// </summary>
        internal string Name { get; set; }

        /// <summary>
        /// The property information.
        /// </summary>
        internal PropertyInfo PropertyInfo { get; set; }

        /// <summary>
        /// True if this is a default field; otherwise false.
        /// </summary>
        internal bool IsDefault { get; set; }

        /// <summary>
        /// True if this is a selected field; otherwise false.
        /// </summary>
        internal bool IsSelected { get; set; }

        /// <summary>
        /// True if the field is a <see cref="NodeCollection{TEntity}"/>; otherwise false.
        /// </summary>
        internal bool IsConnection
        {
            get => PropertyInfo.PropertyType.IsGenericType && typeof(Node).IsAssignableFrom(PropertyInfo.PropertyType.GetGenericArguments()[0]) && PropertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(NodeCollection<>);
        }

        /// <summary>
        /// True if the field is a <see cref="IList{T}"/> or <see cref="List{T}"/>, otherwise false.
        /// </summary>
        internal bool IsList
        {
            get => PropertyInfo.PropertyType.IsGenericType
                && typeof(Node).IsAssignableFrom(PropertyInfo.PropertyType.GetGenericArguments()[0])
                && (typeof(List<>).IsAssignableFrom(PropertyInfo.PropertyType.GetGenericTypeDefinition()) || typeof(IList<>).IsAssignableFrom(PropertyInfo.PropertyType.GetGenericTypeDefinition()));
        }

        /// <summary>
        /// True if the field is a <see cref="Node"/>.
        /// </summary>
        internal bool IsObject
        {
            get => typeof(Node).IsAssignableFrom(PropertyInfo.PropertyType);
        }

        /// <summary>
        /// True if the field is a <see cref="CustomFieldCollection"/>.
        /// </summary>
        public bool IsCustomFields
        {
            get => typeof(CustomFieldCollection).IsAssignableFrom(PropertyInfo.PropertyType);
        }

        /// <summary>
        /// Create a new instance of the <see cref="ExecutionQueryField"/> class.
        /// </summary>
        /// <param name="name">The field name.</param>
        /// <param name="propertyInfo">The field <see cref="System.Reflection.PropertyInfo"/>.</param>
        internal ExecutionQueryField(string name, PropertyInfo propertyInfo)
        {
            Name = name;
            PropertyInfo = propertyInfo;
        }

        /// <summary>
        /// Returns a String which represents the object instance.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
