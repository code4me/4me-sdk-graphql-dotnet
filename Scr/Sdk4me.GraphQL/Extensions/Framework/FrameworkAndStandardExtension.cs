using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A collection of .NET standard 2.0 and .NET Framework 4.7.2 or higher extension methods.
    /// </summary>
    internal static class FrameworkAndStandardExtension
    {
#if NETSTANDARD2_0 || NET472_OR_GREATER

        /// <summary>
        /// Tries to add the specified key and value to the dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="dictionary">A dictionary with keys of type TKey and values of type TValue.</param>
        /// <param name="key">The key of the value to add.</param>
        /// <param name="value">The value to add.</param>
        /// <returns>True when the key and value are successfully added to the dictionary; false when the dictionary already contains the specified key, in which case nothing gets added.</returns>
        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary is null)
                throw new ArgumentNullException(nameof(dictionary));

            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
                return true;
            }

            return false;
        }

        /// <summary>Returns the maximum value in a generic sequence according to a specified key selector function.</summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TKey">The type of key to compare elements by.</typeparam>
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="keySelector">A function to extract the key for each element.</param>
        /// <returns>The value with the maximum key in the sequence.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">No key extracted from <paramref name="source" /> implements the <see cref="IComparable" /> or <see cref="IComparable{TKey}" /> interface.</exception>
        /// <remarks>
        /// <para>If <typeparamref name="TKey" /> is a reference type and the source sequence is empty or contains only values that are <see langword="null" />, this method returns <see langword="null" />.</para>
        /// </remarks>
        public static TSource? MaxBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (keySelector == null)
                throw new ArgumentNullException(nameof(keySelector));

            IComparer<TKey> comparer = Comparer<TKey>.Default;

            using IEnumerator<TSource> e = source.GetEnumerator();

            if (!e.MoveNext())
            {
                if (default(TSource) is null)
                    return default;
                else
                    throw new InvalidOperationException("Sequence contains no elements");
            }

            TSource value = e.Current;
            TKey key = keySelector(value);

            if (default(TKey) is null)
            {
                while (key == null)
                {
                    if (!e.MoveNext())
                        return value;
                    value = e.Current;
                    key = keySelector(value);
                }

                while (e.MoveNext())
                {
                    TSource nextValue = e.Current;
                    TKey nextKey = keySelector(nextValue);
                    if (nextKey != null && comparer.Compare(nextKey, key) > 0)
                    {
                        key = nextKey;
                        value = nextValue;
                    }
                }
            }
            else
            {
                if (comparer == Comparer<TKey>.Default)
                {
                    while (e.MoveNext())
                    {
                        TSource nextValue = e.Current;
                        TKey nextKey = keySelector(nextValue);
                        if (Comparer<TKey>.Default.Compare(nextKey, key) > 0)
                        {
                            key = nextKey;
                            value = nextValue;
                        }
                    }
                }
                else
                {
                    while (e.MoveNext())
                    {
                        TSource nextValue = e.Current;
                        TKey nextKey = keySelector(nextValue);
                        if (comparer.Compare(nextKey, key) > 0)
                        {
                            key = nextKey;
                            value = nextValue;
                        }
                    }
                }
            }

            return value;
        }
#endif

#if NETSTANDARD2_0

        /// <summary>
        /// Creates a <see cref="HashSet{T}"/> from an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">An <see cref="IEnumerable{T}"/> to create a <see cref="HashSet{T}"/> from.</param>
        /// <returns>A <see cref="HashSet{T}"/> that contains values of type TSource selected from the input sequence.</returns>
        public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source)
        {
            HashSet<TSource> retval = new();
            foreach (TSource item in source)
                retval.Add(item);
            return retval;
        }
#endif
    }
}
