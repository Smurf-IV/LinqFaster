using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

using JM.LinqFaster.Utils;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global


namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        // --------------------------  Lists  --------------------------------------------

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this IList<byte> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case byte[] sa:
                    return sa.SumF();
                case List<byte> sl:
                    return NumericPolicies.Instance.SumF<NumericPolicies, byte, uint>(sl);
                default:
                    int sourceCount = source.Count;
                    uint sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this IList<sbyte> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case sbyte[] sa:
                    return sa.SumF();
                case List<sbyte> sl:
                    return NumericPolicies.Instance.SumF<NumericPolicies, sbyte, int>(sl);
                default:
                    int sourceCount = source.Count;
                    int sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this IList<ushort> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case ushort[] sa:
                    return sa.SumF();
                case List<ushort> sl:
                    return NumericPolicies.Instance.SumF<NumericPolicies, ushort, uint>(sl);
                default:
                    int sourceCount = source.Count;
                    uint sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this IList<short> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case short[] sa:
                    return sa.SumF();
                case List<short> sl:
                    return NumericPolicies.Instance.SumF<NumericPolicies, short, int>(sl);
                default:
                    int sourceCount = source.Count;
                    int sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SumF(this IList<uint> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case uint[] sa:
                    return sa.SumF();
                case List<uint> sl:
                    return NumericPolicies.Instance.SumF(sl);
                default:
                    int sourceCount = source.Count;
                    uint sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this IList<int> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case int[] sa:
                    return sa.SumF();
                case List<int> sl:
                    return NumericPolicies.Instance.SumF(sl);
                default:
                    int sourceCount = source.Count;
                    int sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong SumF(this IList<ulong> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case ulong[] sa:
                    return sa.SumF();
                case List<ulong> sl:
                    return NumericPolicies.Instance.SumF(sl);
                default:
                    int sourceCount = source.Count;
                    ulong sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SumF(this IList<long> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case long[] sa:
                    return sa.SumF();
                case List<long> sl:
                    return NumericPolicies.Instance.SumF(sl);
                default:
                    int sourceCount = source.Count;
                    long sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SumF(this IList<float> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case float[] sa:
                    return sa.SumF();
                case List<float> sl:
                    return (float)NumericPolicies.Instance.SumF<NumericPolicies, float, double>(sl);
                default:
                    int sourceCount = source.Count;
                    double sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return (float) sum;
            }
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
        public static double SumF(this IList<double> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case double[] sa:
                    return sa.SumF();
                case List<double> sl:
                    return NumericPolicies.Instance.SumF(sl);
                default:
                    int sourceCount = source.Count;
                    double sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal SumF(this IList<decimal> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case decimal[] sa:
                    return sa.SumF();
                case List<decimal> sl:
                    return NumericPolicies.Instance.SumF(sl);
                default:
                    int sourceCount = source.Count;
                    decimal sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i];
                    }
                    return sum;
            }
        }

        /// <summary>
        /// Adds the transformed sequence of elements.
        /// </summary>        
        /// <param name="source">The sequence of values to transform then sum.</param>
        /// <param name="selector">A transformation function.</param>
        /// <returns>The sum of the transformed elements.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T2 SumF<T, T2>(this List<T> source, Func<T, T2> selector)
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
                    a = GenericOperators.Add(a, selector(source[index]));
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T2 SumF<T, T2>(this IList<T> source, Func<T, T2> selector)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case T[] sa:
                    return sa.SumF(selector);
                case List<T> sl:
                    return sl.SumF(selector);
                default:
                {
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
                            a = GenericOperators.Add(a, selector(source[index]));
                        }
                    }

                    return a;
                }
            }
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

        #region Nullable types
        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? SumF(this IList<byte?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case byte?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<byte?> sl:
                    return NumericPolicies.Instance.SumFNullable<NumericPolicies, byte, uint>(sl);
                default:
                    int sourceCount = source.Count;
                    uint sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? SumF(this IList<sbyte?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case sbyte?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<sbyte?> sl:
                    return NumericPolicies.Instance.SumFNullable<NumericPolicies, sbyte, int>(sl);
                default:
                    int sourceCount = source.Count;
                    int sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? SumF(this IList<ushort?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case ushort?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<ushort?> sl:
                    return NumericPolicies.Instance.SumFNullable<NumericPolicies, ushort, uint>(sl);
                default:
                    int sourceCount = source.Count;
                    uint sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? SumF(this IList<short?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case short?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<short?> sl:
                    return NumericPolicies.Instance.SumFNullable<NumericPolicies, short, int>(sl);
                default:
                    int sourceCount = source.Count;
                    int sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? SumF(this IList<uint?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case uint?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<uint?> sl:
                    return NumericPolicies.Instance.SumFNullable(sl);
                default:
                    int sourceCount = source.Count;
                    uint sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? SumF(this IList<int?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case int?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<int?> sl:
                    return NumericPolicies.Instance.SumFNullable(sl);
                default:
                    int sourceCount = source.Count;
                    int sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong? SumF(this IList<ulong?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case ulong?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<ulong?> sl:
                    return NumericPolicies.Instance.SumFNullable(sl);
                default:
                    int sourceCount = source.Count;
                    ulong sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long? SumF(this IList<long?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case long?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<long?> sl:
                    return NumericPolicies.Instance.SumFNullable(sl);
                default:
                    int sourceCount = source.Count;
                    long sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float? SumF(this IList<float?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case float?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<float?> sl:
                    return (float?)NumericPolicies.Instance.SumFNullable<NumericPolicies, float, double>(sl);
                default:
                    int sourceCount = source.Count;
                    double sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return (float?) sum;
            }
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
        public static T2 SumF<T2>(this List<float?> source, Func<float?, T2> selector)
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
            INumericPolicy<double> p = NumericPolicies.Instance;
            double a = 0;
            checked
            {
                for (int index = 0; index < sourceCount; index++)
                {
                    a = p.Add(a, selector(source[index]).ToDouble(CultureInfo.InvariantCulture));
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
        public static double? SumF(this IList<double?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case double?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<double?> sl:
                    return NumericPolicies.Instance.SumFNullable(sl);
                default:
                    int sourceCount = source.Count;
                    double sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        /// <summary>
        ///  Adds a sequence of values.
        /// </summary>
        /// <param name="source">The sequence to add.</param>
        /// <returns>The sum of the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal? SumF(this IList<decimal?> source)
        {
            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case decimal?[] sa:
                    return SumF(sa); // Do this to prevent compiler causing recursion in to this same function
                case List<decimal?> sl:
                    return NumericPolicies.Instance.SumFNullable(sl);
                default:
                    int sourceCount = source.Count;
                    decimal sum = 0;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        sum = sum + source[i] ?? 0;
                    }
                    return sum;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T2 SumFNullable<P, T, T2>(this P p, List<T?> source)
            where P : INullableNumericPolicy<T, T2>
            where T : struct, IConvertible
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
        private static T SumFNullable<P, T>(this P p, List<T?> source)
            where P : INullableNumericPolicy<T>
            where T : struct, IConvertible
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

        #endregion Nullable Types
    }
}
