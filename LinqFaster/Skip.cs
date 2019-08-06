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

            T[] result = new T[source.Length - count];
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
                throw Error.ArgumentNull("predicate");
            }

            int i = 0;
            for (; i < source.Length; i++)
            {
                if (!predicate(source[i])) break;
            }
            T[] result = new T[source.Length - i];
            Array.Copy(source, i, result, 0, result.Length);
            return result;
        }

        /*------------- SPans ---------------- */

        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// </summary>        
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
        /// <returns>A sequence that contains the elements that occur after the specified index in the input sequence.</returns>
        public static T[] SkipF<T>(this Span<T> source, int count)
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

            T[] result = new T[source.Length - count];
            for (int i = count; i < source.Length; i++)
            {
                result[i - count] = source[i];
            }            
            return result;
        }

        /// <summary>
        ///  Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
        /// </summary>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
        public static T[] SkipWhileF<T>(this Span<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }

            int count = 0;
            for (; count < source.Length; count++)
            {
                if (!predicate(source[count])) break;
            }
            T[] result = new T[source.Length - count];
            for (int i = count; i < source.Length; i++)
            {
                result[i - count] = source[i];
            }
            return result;
        }




        // ------------- Lists ----------------

        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// </summary>        
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
        /// <returns>A sequence that contains the elements that occur after the specified index in the input sequence.</returns>
        public static List<T> SkipF<T>(this List<T> source, int count)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (count < 0)
            {
                count = 0;
            }
            else if (count > source.Count)
            {
                return new List<T>();
            }

            List<T> result = new List<T>(source.Count - count);
            for (int i = count; i < source.Count; i++)
            {
                result.Add(source[i]);
            }
            return result;
        }

        /// <summary>
        ///  Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
        /// </summary>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>A sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
        public static List<T> SkipWhileF<T>(this List<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }

            int i = 0;
            for (; i < source.Count; i++)
            {
                if (!predicate(source[i])) {
                    break;
                }
            }

            List<T> result = new List<T>(source.Count - i);
            for (; i < source.Count; i++)
            {
                result.Add(source[i]);
            }
            return result;
        }

      
    }
}
