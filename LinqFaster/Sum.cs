using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using JM.LinqFaster.Utils;


namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        // --------------------------  ARRAYS  --------------------------------------------

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this byte[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, byte, uint>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this sbyte[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, sbyte, int>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this ushort[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, ushort, uint>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this short[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, short, int>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this uint[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, uint>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this int[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, int>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong SumF(this ulong[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, ulong>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SumF(this long[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, long>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SumF(this float[] source)
        {
            return (float)NumericPolicies.Instance.SumF<NumericPolicies, float, double>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SumF(this double[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, double>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal SumF(this decimal[] source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, Decimal>(source);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T2 SumF<P, T1, T2>(this P p, T1[] source)
            where P : INumericPolicy<T1, T2>
            where T1 : IConvertible
            where T2 : IConvertible
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            T2 a = p.Zero();
            checked
            {
                foreach (T1 b in source)
                {
                    a = p.Add(a, b);
                }
            }

            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T SumF<P, T>(this P p, T[] source) 
            where P : INumericPolicy<T>
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            T a = p.Zero();
            checked
            {
                foreach (T b in source)
                {
                    a = p.Add(a, b);
                }
            }

            return a;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int SumF<T>(this T[] source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            int sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    sum += selector(v);
                }
            }
            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long SumF<T>(this T[] source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            long sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    sum += selector(v);
                }
            }
            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float SumF<T>(this T[] source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                sum += selector(v);
            }

            return (float)sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double SumF<T>(this T[] source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                sum += selector(v);
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal SumF<T>(this T[] source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            decimal sum = 0;
            foreach (var v in source)
            {
                sum += selector(v);
            }

            return sum;
        }

        /*---- Spans ---*/

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumF(this Span<int> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            int sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    sum += v;
                }
            }
            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int SumF<T>(this Span<T> source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            int sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    sum += selector(v);
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long SumF(this Span<long> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            long sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    sum += v;
                }
            }
            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long SumF<T>(this Span<T> source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            long sum = 0;
            checked
            {
                foreach (var v in source)
                {
                    sum += selector(v);
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float SumF(this Span<float> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;

            foreach (var v in source)
            {
                sum += v;
            }

            return (float)sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float SumF<T>(this Span<T> source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                sum += selector(v);
            }

            return (float)sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double SumF(this Span<double> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;
            foreach (var v in source)
            {
                sum += v;
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double SumF<T>(this Span<T> source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            double sum = 0;
            foreach (var v in source)
            {
                sum += selector(v);
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal SumF(this Span<decimal> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            decimal sum = 0;

            foreach (var v in source)
            {
                sum += v;
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal SumF<T>(this Span<T> source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            decimal sum = 0;
            foreach (var v in source)
            {
                sum += selector(v);
            }

            return sum;
        }

        // --------------------------  LISTS  --------------------------------------------

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumF(this List<int> source)
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
                    sum += source[i];
                }
            }
            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static int SumF<T>(this List<T> source, Func<T, int> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            int sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    sum += selector(source[i]);
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long SumF(this List<long> source)
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
                    sum += source[i];
                }
            }
            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static long SumF<T>(this List<T> source, Func<T, long> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            long sum = 0;
            checked
            {
                for (int i = 0; i < source.Count; i++)
                {
                    sum += selector(source[i]);
                }
            }
            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float SumF(this List<float> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return (float)sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static float SumF<T>(this List<T> source, Func<T, float> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                sum += selector(source[i]);
            }

            return (float)sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double SumF(this List<double> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static double SumF<T>(this List<T> source, Func<T, double> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            double sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                sum += selector(source[i]);
            }

            return sum;
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal SumF(this List<decimal> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            decimal sum = 0;

            for (int i = 0; i < source.Count; i++)
            {
                sum += source[i];
            }

            return sum;
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        public static decimal SumF<T>(this List<T> source, Func<T, decimal> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            decimal sum = 0;
            for (int i = 0; i < source.Count; i++)
            {
                sum += selector(source[i]);
            }

            return sum;
        }

    }
}
