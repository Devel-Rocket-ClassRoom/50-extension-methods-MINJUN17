using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ChunkExtension
{
    public static void Chunk<T>(this IEnumerable<T> values, int size)
    {
        values.Count<T>   
    }
}