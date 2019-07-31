using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

using JM.LinqFaster.Utils;


namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        // --------------------------  Lists  --------------------------------------------
        // TODO: Add the nullable types in

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this List<byte> source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, byte, uint>(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static uint SumF(this IList<byte> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is byte[] sa)
                return sa.SumF();
            if (source is List<byte> sl)
                return sl.SumF();
            return source.Aggregate(0U, (current, s1) => current + s1);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this List<sbyte> source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, sbyte, int>(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumF(this IList<sbyte> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is sbyte[] sa)
                return sa.SumF();
            if (source is List<sbyte> sl)
                return sl.SumF();
            return source.Aggregate(0, (current, s1) => current + s1);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this List<ushort> source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, ushort, uint>(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static uint SumF(this IList<ushort> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is ushort[] sa)
                return sa.SumF();
            if (source is List<ushort> sl)
                return sl.SumF();
            return source.Aggregate(0U, (current, s1) => current + s1);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this List<short> source)
        {
            return NumericPolicies.Instance.SumF<NumericPolicies, short, int>(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumF(this IList<short> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is short[] sa)
                return sa.SumF();
            if (source is List<short> sl)
                return sl.SumF();
            return source.Aggregate(0, (current, s1) => current + s1);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this List<uint> source)
        {
            return NumericPolicies.Instance.SumF(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static uint SumF(this IList<uint> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is uint[] sa)
                return sa.SumF();
            if (source is List<uint> sl)
                return sl.SumF();
            return (uint) source.Aggregate(0UL, (current, s1) => (current + s1));
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this List<int> source)
        {
            return NumericPolicies.Instance.SumF(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static int SumF(this IList<int> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is int[] sa)
                return sa.SumF();
            if (source is List<int> sl)
                return sl.SumF();
            return source.Sum();
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong SumF(this List<ulong> source)
        {
            return NumericPolicies.Instance.SumF(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static ulong SumF(this IList<ulong> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is ulong[] sa)
                return sa.SumF();
            if (source is List<ulong> sl)
                return sl.SumF();
            return source.Aggregate(0UL, (current, s1) => (current + s1));
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SumF(this List<long> source)
        {
            return NumericPolicies.Instance.SumF(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static long SumF(this IList<long> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is long[] sa)
                return sa.SumF();
            if (source is List<long> sl)
                return sl.SumF();
            return source.Sum();
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SumF(this List<float> source)
        {
            return (float)NumericPolicies.Instance.SumF<NumericPolicies, float, double>(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static float SumF(this IList<float> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is float[] sa)
                return sa.SumF();
            if (source is List<float> sl)
                return sl.SumF();
            return source.Sum();
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        /// <remarks>
        /// Special case for floats, as IEnumerable does the sums on doubles before returning the type.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T2 SumF<T2>(this List<float> source, Func<float, T2> selector)
            where T2 : struct, IConvertible // Make sure these are not nullable
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            INumericPolicy<double> p = NumericPolicies.Instance;
            double a = 0;
            checked
            {
                foreach (float b in source)
                {
                    a = p.Add(a, selector(b).ToDouble(CultureInfo.InvariantCulture));
                }
            }

            return (T2)Convert.ChangeType(a, typeof(T2));
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SumF(this List<double> source)
        {
            return NumericPolicies.Instance.SumF(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static double SumF(this IList<double> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is double[] sa)
                return sa.SumF();
            if (source is List<double> sl)
                return sl.SumF();
            return source.Sum();
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal SumF(this List<decimal> source)
        {
            return NumericPolicies.Instance.SumF(source);
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        public static decimal SumF(this IList<decimal> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));
            if (source is decimal[] sa)
                return sa.SumF();
            if (source is List<decimal> sl)
                return sl.SumF();
            return source.Sum();
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T2 SumF<T, T2>(this List<T> source, Func<T, T2> selector)
            where T : struct, IConvertible
            where T2 : struct, IConvertible // Make sure these are not nullable
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }

            int sourceCount = source.Count;
            T2 a = default(T2);
            checked
            {
                for (int index = 0; index < sourceCount; index++)
                {
                    a = GenericOperators.Add<T2>(a, selector(source[index]));
                }
            }

            return a;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T2 SumF<P, T1, T2>(this P p, List<T1> source)
            where P : INumericPolicy<T1, T2>
            where T1 : IConvertible
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            T2 a = p.Zero();
            checked
            {
                for (int index = 0; index < sourceCount; index++)
                {
                    a = p.Add(a, source[index]);
                }
            }

            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T SumF<P, T>(this P p, List<T> source)
            where P : INumericPolicy<T>
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            int sourceCount = source.Count;
            T a = p.Zero();
            checked
            {
                for (int index = 0; index < sourceCount; index++)
                {
                    a = p.Add(a, source[index]);
                }
            }

            return a;
        }

    }
}
