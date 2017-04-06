﻿using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// </summary>        
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
        /// <returns>A sequence that contains the elements that occur after the specified index in the input sequence.</returns>
        public static T[] SkipF<T>(this T[] source, int count)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (count < 0)
            {
                count = 0;
            }
            else if (count > source.Length)
            {
                return new T[0];
            }

            var result = new T[source.Length - count];
            Array.Copy(source, count, result, 0, result.Length);
            return result;
        }

        /// <summary>
        ///  Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
        /// </summary>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
        public static T[] SkipWhileF<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull(nameof(predicate));
            }

            int i = 0;
            for (; i < source.Length; i++)
            {
                if (!predicate(source[i])) break;
            }
            var result = new T[source.Length - i];
            Array.Copy(source, i, result, 0, result.Length);
            return result;
        }



        // ------------- Lists ----------------

        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// </summary>        
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
        /// <returns>A sequence that contains the elements that occur after the specified index in the input sequence.</returns>
        public static List<T> SkipF<T>(this List<T> a, int count)
        {
            if (a == null)
            {
                throw Error.ArgumentNull(nameof(a));
            }
            if (count < 0)
            {
                count = 0;
            }
            else if (count > a.Count)
            {
                return new List<T>();
            }

            var result = new List<T>(a.Count - count);
            for (int i = count; i < a.Count; i++)
            {
                result.Add(a[i]);
            }
            return result;
        }

        /// <summary>
        ///  Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
        /// </summary>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
        public static List<T> SkipWhileF<T>(this List<T> a, Func<T, bool> predicate)
        {
            if (a == null)
            {
                throw Error.ArgumentNull(nameof(a));
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull(nameof(predicate));
            }

            int i = 0;
            for (; i < a.Count; i++)
            {
                if (!predicate(a[i])) {
                    break;
                }
            }

            var result = new List<T>(a.Count - i);
            for (; i < a.Count; i++)
            {
                result.Add(a[i]);
            }
            return result;
        }

      
    }
}
