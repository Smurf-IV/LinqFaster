﻿using System;
using System.Collections.Generic;

namespace JM.LinqFasterSpan
{

    public static partial class LinqFasterSpan
    {
        
        // --------------------------  Spans --------------------------------------------

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>        
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>        
        public static T[] WhereF<T>(this Span<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }

            T[] result = new T[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    result[idx] = source[i];
                    idx++;
                }
            }
            Array.Resize(ref result, idx);
            return result;
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate that includes the index in it's logic.
        /// </summary>        
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition along with the element's index.</param>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        public static T[] WhereF<T>(this Span<T> source, Func<T, int, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }


            T[] result = new T[source.Length];
            int idx = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i], i))
                {
                    result[idx] = source[i];
                    idx++;
                }
            }
            Array.Resize(ref result, idx);
            return result;
        }
        
    }
}
