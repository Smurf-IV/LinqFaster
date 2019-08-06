﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
// ReSharper disable ForCanBeConvertedToForeach
// ReSharper disable UnusedMember.Global
// ReSharper disable LoopCanBeConvertedToQuery

namespace JM.LinqFaster
{
    // Common types optimised: int, long, float, double, decimal
    // Other types will be handled via the templates which are approx 2 time longer than 
    // the above optimised base types
    public static partial class LinqFaster
    {
        // Note: although there is a lot of shared code in the following
        // comparers, we do not incorporate it into a base class for perf
        // reasons. Adding another base class (even one with no fields)
        // means another generic instantiation, which can be costly esp.
        // for value types.

        // --------------------------  LISTS  --------------------------------------------

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T MaxF<T>(this List<T> source)
            where T : IComparable<T>
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }

            T r = source[0];
            if (default(T) == null)
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    T item = source[i];
                    if (item != null
                        && item.CompareTo(r) > 0)
                        r = item;
                }
            }
            else
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    T item = source[i];
                    if (item.CompareTo(r) > 0)
                        r = item;
                }
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult MaxF<T, TResult>(this List<T> source, Func<T, TResult> selector)
            where TResult : IComparable<TResult>
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }

            TResult r = selector(source[0]);
            if (default(TResult) == null)
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    TResult item = selector(source[i]);
                    if (item != null
                        && item.CompareTo(r) > 0)
                    {
                        r = item;
                    }
                }
            }
            else
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    TResult item = selector(source[i]);
                    if (item.CompareTo(r) > 0)
                        r = item;
                }
            }
            return r;
        }


        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MaxF(this List<int> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            int r = source[0];
            for (int i = 1; i < sourceCount; i++)
            {
                if (source[i] > r) r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MaxF<T>(this List<T> source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            int r = selector(source[0]);
            for (int i = 1; i < sourceCount; i++)
            {
                int v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long MaxF(this List<long> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            long r = source[0];
            for (int i = 1; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long MaxF<T>(this List<T> source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            long r = selector(source[0]);
            for (int i = 1; i < sourceCount; i++)
            {
                long v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxF(this List<float> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            float r = source[0];
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                if (float.IsNaN(source[startIndex])) continue;
                r = source[startIndex];
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxF<T>(this List<T> source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }
            float r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                float v = selector(source[startIndex]);
                if (float.IsNaN(v)) continue;
                r = v;
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                float v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxF(this List<double> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            double r = source[0];
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                if (double.IsNaN(source[startIndex])) continue;
                r = source[startIndex];
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxF<T>(this List<T> source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }
            double r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                double v = selector(source[startIndex]);
                if (double.IsNaN(v)) continue;
                r = v;
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                double v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal MaxF(this List<decimal> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            decimal r = source[0];
            for (int i = 1; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal MaxF<T>(this List<T> source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            decimal r = selector(source[0]);
            for (int i = 1; i < sourceCount; i++)
            {
                decimal v = selector(source[i]);
                if (v > r) r = v;
            }
            return r;
        }

        // --------------------------  IReadOnlyList  --------------------------------------------

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T MaxF<T>(this IReadOnlyList<T> source)
            where T : IComparable<T>
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }

            T r = source[0];
            if (default(T) == null)
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    T item = source[i];
                    if (item != null
                        && item.CompareTo(r) > 0)
                        r = item;
                }
            }
            else
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    T item = source[i];
                    if (item.CompareTo(r) > 0)
                        r = item;
                }
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult MaxF<T, TResult>(this IReadOnlyList<T> source, Func<T, TResult> selector)
            where TResult : IComparable<TResult>
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }

            TResult r = selector(source[0]);
            if (default(TResult) == null)
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    TResult item = selector(source[i]);
                    if (item != null
                        && item.CompareTo(r) > 0)
                    {
                        r = item;
                    }
                }
            }
            else
            {
                for (int i = 1; i < sourceCount; i++)
                {
                    TResult item = selector(source[i]);
                    if (item.CompareTo(r) > 0)
                        r = item;
                }
            }
            return r;
        }


        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MaxF(this IReadOnlyList<int> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            int r = source[0];
            for (int i = 1; i < sourceCount; i++)
            {
                if (source[i] > r) r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MaxF<T>(this IReadOnlyList<T> source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            int r = selector(source[0]);
            for (int i = 1; i < sourceCount; i++)
            {
                int v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long MaxF(this IReadOnlyList<long> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            long r = source[0];
            for (int i = 1; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long MaxF<T>(this IReadOnlyList<T> source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            long r = selector(source[0]);
            for (int i = 1; i < sourceCount; i++)
            {
                long v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxF(this IReadOnlyList<float> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            float r = source[0];
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                if (float.IsNaN(source[startIndex])) continue;
                r = source[startIndex];
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float MaxF<T>(this IReadOnlyList<T> source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }
            float r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                float v = selector(source[startIndex]);
                if (float.IsNaN(v)) continue;
                r = v;
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                float v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxF(this IReadOnlyList<double> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            double r = source[0];
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                if (double.IsNaN(source[startIndex])) continue;
                r = source[startIndex];
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double MaxF<T>(this IReadOnlyList<T> source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }
            double r = selector(source[0]);
            int startIndex = 0;
            for (; startIndex < sourceCount; startIndex++)
            {
                double v = selector(source[startIndex]);
                if (double.IsNaN(v)) continue;
                r = v;
                break;
            }
            for (int i = startIndex; i < sourceCount; i++)
            {
                double v = selector(source[i]);
                if (v > r)
                    r = v;
            }
            return r;
        }

        /// <summary>
        /// Returns the maximum value in a sequence of values.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum of.</param>
        /// <returns>The maximum value in the sequence</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal MaxF(this IReadOnlyList<decimal> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            decimal r = source[0];
            for (int i = 1; i < sourceCount; i++)
            {
                if (source[i] > r)
                    r = source[i];
            }
            return r;
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum value.
        /// </summary>        
        /// <param name="source">A sequence of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The maximum value in the transform of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal MaxF<T>(this IReadOnlyList<T> source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            if (sourceCount == 0)
            {
                throw Error.NoElements();
            }
            decimal r = selector(source[0]);
            for (int i = 1; i < sourceCount; i++)
            {
                decimal v = selector(source[i]);
                if (v > r) r = v;
            }
            return r;
        }


    }
}
