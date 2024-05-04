using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A generic 4me keyed collection list.
    /// </summary>
    /// <typeparam name="T">Any type implementing <see cref="Node"/>.</typeparam>
    public sealed class DataList<T> : KeyedCollection<string, T> where T : Node
    {
        /// <summary>
        /// Extracts the key from the specified element.
        /// </summary>
        /// <param name="item">The element from which to extract the key.</param>
        /// <returns>The key for the specified element.</returns>
        protected override string GetKeyForItem(T item)
        {
            return item.UniqueIdentifier;
        }

        /// <summary>
        /// Adds an element to the end of the <see cref="DataList{T}"/>.
        /// <br>If the element already exists it will merge it with the existing element.</br>
        /// </summary>
        /// <param name="item">The object to add.</param>
        public new void Add(T item)
        {
            if (Contains(item.UniqueIdentifier))
                this[item.UniqueIdentifier].AddToCollection(item);
            else
                base.Add(item);
        }

        /// <summary>
        /// Inserts an element into the <see cref="DataList{T}"/> at the specified index.
        /// <br>If the element already exists it will merge it with the existing element. In that case the index will be ignored.</br>
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The object to insert. The value cannot be null.</param>
        protected override void InsertItem(int index, T item)
        {
            if (Contains(item.UniqueIdentifier))
                this[item.UniqueIdentifier].AddToCollection(item);
            else
                base.InsertItem(index, item);
        }

        /// <summary>
        /// Adds the elements of the specified collection to the end of the <see cref="DataList{T}"/>.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the <see cref="DataList{T}"/>. 
        /// </param>
        public void AddRange(IEnumerable<T>? collection)
        {
            if (collection != null)
            {
                foreach (T item in collection)
                    Add(item);
            }
        }
    }
}
