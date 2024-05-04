using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A custom field collection.
    /// </summary>
    public class CustomFieldCollection : KeyedCollection<string, CustomField>
    {
        /// <summary>
        /// Extracts the key from the specified element.
        /// </summary>
        /// <param name="item">The element from which to extract the key.</param>
        /// <returns>The key for the specified element.</returns>
        protected override string GetKeyForItem(CustomField item)
        {
            return item.ID;
        }

        /// <summary>
        /// Add an object to the end of the <see cref="Collection{T}"/>.
        /// </summary>
        /// <param name="ID">The unique identifier.</param>
        /// <param name="value">
        /// <br>Value of the field.</br>
        /// <br> * For `select` fields the value is the HTML `value` defined for the value (not the value shown to the user).</br>
        /// <br> * For `...-suggest` fields the value is the node identifier of the selected record.</br>
        /// <br> * For `custom-suggest` fields the value is the node identifier of the selected record. When multiple records are selected the value is an array of node IDs.</br>.
        /// </param>
        public void Add(string ID, JToken? value)
        {
            Add(new CustomField() { ID = ID, Value = value });
        }

        /// <summary>
        /// Add an object to the end of the <see cref="Collection{T}"/>, or updating an existing object.
        /// </summary>
        /// <param name="ID">The unique identifier.</param>
        /// <param name="value">
        /// <br>Value of the field.</br>
        /// <br> * For `select` fields the value is the HTML `value` defined for the value (not the value shown to the user).</br>
        /// <br> * For `...-suggest` fields the value is the node identifier of the selected record.</br>
        /// <br> * For `custom-suggest` fields the value is the node identifier of the selected record. When multiple records are selected the value is an array of node IDs.</br>.
        /// </param>
        public void AddOrUpdate(string ID, JToken? value)
        {
            if (!Contains(ID))
                Add(new CustomField() { ID = ID, Value = value });
            else
                this[ID].Value = value;
        }
    }
}
