namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of <see cref="HashSet{T}"/> extension methods.
    /// </summary>
    public static class HashSetExtension
    {
        /// <summary>
        /// Adds the specified elements to the <see cref="HashSet{T}"/>.
        /// </summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="source">The current <see cref="HashSet{T}"/>.</param>
        /// <param name="items">The elements to add to the set.</param>
        public static void AddRange<T>(this HashSet<T> source, IEnumerable<T>? items)
        {
            if (items != null)
            {
                foreach (T item in items)
                {
                    if (item != null)
                    {
                        source.Add(item);
                    }
                }
            }
        }
    }
}
