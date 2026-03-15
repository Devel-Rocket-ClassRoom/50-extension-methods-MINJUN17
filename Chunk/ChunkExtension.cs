using System;
using System.Collections.Generic;

public static class CollectionExtensions
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int size)
    {
        if (size < 1)
            throw new ArgumentException("청크 사이즈가 1보다 작음");

        List<T> chunk = new List<T>(size);

        foreach (T item in source)
        {
            chunk.Add(item);
            if (chunk.Count == size)
            {
                yield return chunk;
                chunk = new List<T>(size);
            }
        }
        if (chunk.Count > 0)
        {
            yield return chunk;
        }
    }
}