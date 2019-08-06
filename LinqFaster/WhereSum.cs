﻿using System;
using System.Collections.Generic;


namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        // --------------------------  ARRAYS  --------------------------------------------

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int WhereSumF(this int[] source, Func<int,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            int sum = 0;
            checked
            {
                foreach (int v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int WhereSumF<T>(this T[] source,Func<T,bool> predicate, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            int sum = 0;
            checked
            {
                foreach (T v in source)
                {                    
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long WhereSumF(this long[] source,Func<long,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            long sum = 0;
            checked
            {
                foreach (long v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long WhereSumF<T>(this T[] source,Func<T,bool> predicate, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            long sum = 0;
            checked
            {
                foreach (T v in source)
                {
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float WhereSumF(this float[] source, Func<float,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;

            foreach (float v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return (float)sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>        
        /// <returns>The sum of the transformed elements.</returns>
        public static float WhereSumF<T>(this T[] source, Func<T,bool> predicate,Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            double sum = 0;
            foreach (T v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return (float)sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double WhereSumF(this double[] source, Func<double,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;
            foreach (double v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double WhereSumF<T>(this T[] source, Func<T,bool> predicate,Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            double sum = 0;
            foreach (T v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal WhereSumF(this decimal[] source, Func<decimal,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            decimal sum = 0;

            foreach (decimal v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal WhereSumF<T>(this T[] source,Func<T,bool> predicate, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            decimal sum = 0;
            foreach (T v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        // --------------------------  SPANS  --------------------------------------------

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int WhereSumF(this Span<int> source, Func<int, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            int sum = 0;
            checked
            {
                foreach (int v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int WhereSumF<T>(this Span<T> source, Func<T, bool> predicate, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            int sum = 0;
            checked
            {
                foreach (T v in source)
                {
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long WhereSumF(this Span<long> source, Func<long, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            long sum = 0;
            checked
            {
                foreach (long v in source)
                {
                    if (predicate(v))
                    {
                        sum += v;
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long WhereSumF<T>(this Span<T> source, Func<T, bool> predicate, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            long sum = 0;
            checked
            {
                foreach (T v in source)
                {
                    if (predicate(v))
                    {
                        sum += selector(v);
                    }
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float WhereSumF(this Span<float> source, Func<float, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;

            foreach (float v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return (float)sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>        
        /// <returns>The sum of the transformed elements.</returns>
        public static float WhereSumF<T>(this Span<T> source, Func<T, bool> predicate, Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            double sum = 0;
            foreach (T v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return (float)sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double WhereSumF(this Span<double> source, Func<double, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;
            foreach (double v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double WhereSumF<T>(this Span<T> source, Func<T, bool> predicate, Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            double sum = 0;
            foreach (T v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal WhereSumF(this Span<decimal> source, Func<decimal, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            decimal sum = 0;

            foreach (decimal v in source)
            {
                if (predicate(v))
                {
                    sum += v;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal WhereSumF<T>(this Span<T> source, Func<T, bool> predicate, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            decimal sum = 0;
            foreach (T v in source)
            {
                if (predicate(v))
                {
                    sum += selector(v);
                }
            }

            return sum;
        }

        // --------------------------  LISTS  --------------------------------------------

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int WhereSumF(this List<int> source, Func<int,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            int sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    int s = source[i];
                    if (predicate(s))
                    {
                        sum += s;
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int WhereSumF<T>(this List<T> source, Func<T,bool> predicate, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            int sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    T s = source[i];
                    if (predicate(s))
                    {
                        sum += selector(s);
                    }
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long WhereSumF(this List<long> source, Func<long,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    long s = source[i];
                    if (predicate(s))
                    {
                        sum += s;
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long WhereSumF<T>(this List<T> source, Func<T,bool> predicate, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    T s = source[i];
                    if (predicate(s))
                    {
                        sum += selector(s);
                    }
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float WhereSumF(this List<float> source, Func<float,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                float s = source[i];
                if (predicate(s))
                {
                    sum += s;
                }
            }

            return (float)sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float WhereSumF<T>(this List<T> source, Func<T,bool> predicate,Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                T s = source[i];
                if (predicate(s))
                {
                    sum += selector(s);
                }
            }

            return (float)sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double WhereSumF(this List<double> source, Func<double,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                double s = source[i];
                if (predicate(s))
                {
                    sum += s;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double WhereSumF<T>(this List<T> source,Func<T,bool> predicate, Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                T s = source[i];
                if (predicate(s))
                {
                    sum += selector(s);
                }
            }

            return sum;
        }

        /// <summary>
        ///  Adds the values in the sequence that match the where predicate.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal WhereSumF(this List<decimal> source, Func<decimal,bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            decimal sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                decimal s = source[i];
                if (predicate(s))
                {
                    sum += s;
                }
            }

            return sum;
        }

        /// <summary>
        /// Performs a filter with the where predicate, then sums the transformed values.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="predicate">A function to filter the sequence with before summing.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal WhereSumF<T>(this List<T> source, Func<T,bool> predicate,Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull(nameof(selector));
            }

            decimal sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                T s = source[i];
                if (predicate(s))
                {
                    sum += selector(s);
                }
            }

            return sum;
        }

    }
}
