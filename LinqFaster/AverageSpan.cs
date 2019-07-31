using System;
using System.Globalization;
using System.Runtime.CompilerServices;

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
        public static float AverageF<T>(this Span<T> source, Func<T, float> selector)
        {
            if (source.Length == 0)
            {
                return 0;
            }

            return SumF(source, selector) / source.Length;
        }
        /// <summary>
        /// Computes the average of values obtained by invoking a transform function on
        /// each element of the input array.
        /// </summary>
        /// <param name="source">The array to calculate the transformed average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF<T, T2>(this Span<T> source, Func<T, T2> selector)
            where T2 : IConvertible
        {
            if (source.Length == 0)
            {
                return 0;
            }

            return SumF(source, selector).ToDouble(CultureInfo.InvariantCulture) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<byte> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<sbyte> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<ushort> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<short> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<uint> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<int> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<ulong> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<long> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return (double)SumF(source) / source.Length;
        }


        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float AverageF(this Span<float> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return SumF(source) / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AverageF(this Span<double> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return source.SumF() / source.Length;
        }

        /// <summary>
        /// Computes the average of an array
        /// </summary>
        /// <param name="source">The array to calculate the average of.</param>
        /// <returns>The average of the array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal AverageF(this Span<decimal> source)
        {
            if (source.Length == 0)
            {
                return 0;
            }
            return SumF(source) / source.Length;
        }

    }
}
