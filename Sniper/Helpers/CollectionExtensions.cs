using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sniper
{
    internal static class CollectionExtensions
    {

        public static IList<string> Clone(this IReadOnlyList<string> input)
        {
            return input?.Select(λ => new string(λ.ToCharArray())).ToList();
        }

        public static IDictionary<string, Uri> Clone(this IReadOnlyDictionary<string, Uri> input)
        {
            return input?.ToDictionary(λ => new string(λ.Key.ToCharArray()), λ => new Uri(λ.Value.ToString()));
        }

        public static IList<T> CollectionToList<T>(this ICollection<T> collection) where T : class
        {
            var list = new List<T>();
            list.AddRange(collection);
            return list;
        }

        public static IReadOnlyCollection<T> ConvertToReadOnlyCollection<T>(this ICollection<T> collection) where T : class
        {
            return new ReadOnlyCollection<T>(collection.CollectionToList());
        }

        public static ICollection<T> ListToCollection<T>(this IList<T> list) where T : class
        {
            var collection = new Collection<T>();
            foreach (var item in list)
            {
                collection.Add(item);
            }
            return collection;
        }

        public static IReadOnlyCollection<T> ListToReadOnlyCollection<T>(this IList<T> list) where T : class
        {
            return new ReadOnlyCollection<T>(list);
        }

        public static TValue SafeGet<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
        {
            Ensure.ArgumentNotNull(nameof(dictionary), dictionary);

            return dictionary.TryGetValue(key, out TValue value) ? value : default(TValue);
        }
    }
}