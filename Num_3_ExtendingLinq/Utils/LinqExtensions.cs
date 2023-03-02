namespace Num_3_ExtendingLinq.Utils;

public static class LinqExtensions
{
    public static TimeSpan Sum(this IEnumerable<TimeSpan> timeSpans)
    {
        var result = TimeSpan.Zero;

        foreach (var timeSpan in timeSpans)
        {
            result += timeSpan;
        }

        return result;
    }

    public static string StringConcat<T>(this IEnumerable<T> strings, string separator)
    {
        return string.Join(separator, strings);
    }

    public static IEnumerable<KeyValuePair<TKey, int>> CountBy<TSource, TKey>(
        this IEnumerable<TSource> source, Func<TSource, TKey> selector) where TKey : notnull
    {
        var result = new Dictionary<TKey, int>();

        foreach (var item in source)
        {
            var key = selector(item);
            if (!result.ContainsKey(key))
            {
                result[key] = 1;
            }
            else result[key]++;
        }

        return result;
    }
}