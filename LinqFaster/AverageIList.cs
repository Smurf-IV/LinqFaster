using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable PossibleInvalidOperationException

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        /// <remarks>
        /// Special case for floats to be equivalent to IEnumerable !
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float AverageF<T>(this IList<T> source, Func<T, float> selector)
        {
            if (source.Count == 0)
            {
                return 0;
            }

            return source.SumF(selector) / source.Count;
        }
        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF<T, T2>(this IList<T> source, Func<T, T2> selector)
            where T2 : IConvertible
        {
            if (source.Count == 0)
            {
                return 0;
            }

            return source.SumF(selector).ToDouble(CultureInfo.InvariantCulture) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<byte> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<sbyte> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<ushort> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<short> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<uint> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<int> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<ulong> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<long> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Count;
        }


        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float AverageF(this IList<float> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return (float)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this IList<double> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return source.SumF() / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal AverageF(this IList<decimal> source)
        {
            if (source.Count == 0)
            {
                return 0;
            }
            return source.SumF() / source.Count;
        }

        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal AverageF<T>(this IList<T> source, Func<T, decimal> selector)
        {
            if (source.Count == 0)
            {
                return 0;
            }

            return SumF(source, selector) / source.Count;
        }

        #region Nullable types
        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<byte?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<sbyte?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<ushort?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<short?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<uint?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<int?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<ulong?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<long?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }


        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<float?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return (double)SumF(source) / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double? AverageF(this IList<double?> source)
        {
            if (source.Count == 0)
            {
                return new double?();
            }
            return source.SumF() / source.Count;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal? AverageF(this IList<decimal?> source)
        {
            if (source.Count == 0)
            {
                return new decimal?();
            }
            return source.SumF() / source.Count;
        }
        #endregion Nullable Types
    }
}
