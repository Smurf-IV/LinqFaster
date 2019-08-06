using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable ForCanBeConvertedToForeach
// ReSharper disable UnusedMember.Global

namespace JM.LinqFaster
{
    /// <summary>
    /// Provides faster array and list specific extension methods with
    /// the same semantics as the Linq extensions methods.
    /// </summary>
    public static partial class LinqFaster
    {

        /// <summary>
        /// Applies an accumulator function over an array[T] / List{T} / or IReadOnlyList{T}.
        /// </summary>        
        /// <param name="source">An IReadOnlyList to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSource AggregateF<TSource>(this IReadOnlyList<TSource> source, 
            Func<TSource, TSource, TSource> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            if (source.Count == 0)
            {
                throw Error.NoElements();
            }

            TSource result = source[0];
            switch (source)
            {
                case TSource[] sa:
                    for (int i = 1; i < sa.Length; i++)
                    {
                        result = func(result, sa[i]);
                    }
                    break;
                case List<TSource> sl:
                    for (int i = 1; i < sl.Count; i++)
                    {
                        result = func(result, sl[i]);
                    }
                    break;
                default:
                    int sourceCount = source.Count;
                    for (int i = 1; i < sourceCount; i++)
                    {
                        result = func(result, source[i]);
                    }
                    break;
            }

            return result;
        }

        /// <summary>
        /// The specified seed value is used as the initial accumulator value.
        /// Applies an accumulator function over an array[T] / List{T} / or IReadOnlyList{T}.
        /// </summary>        
        /// <param name="source">An IReadOnlyList to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate AggregateF<TSource, TAccumulate>(this IReadOnlyList<TSource> source, TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            TAccumulate result = seed;
            switch (source)
            {
                case TSource[] sa:
                    for (int i = 0; i < sa.Length; i++)
                    {
                        result = func(result, sa[i]);
                    }
                    break;
                case List<TSource> sl:
                    for (int i = 0; i < sl.Count; i++)
                    {
                        result = func(result, sl[i]);
                    }
                    break;
                default:
                    int sourceCount = source.Count;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        result = func(result, source[i]);
                    }
                    break;
            }

            return result;
        }

        /// <summary>
        /// The specified seed value is used as the initial accumulator value,
        /// and the specified function is used to select the result value.
        /// Applies an accumulator function over an array[T] / List{T} / or IReadOnlyList{T}.
        /// </summary>        
        /// <param name="source">An IReadOnlyList to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <returns>The transformed final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this IReadOnlyList<TSource> source, TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func, 
            Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            if (resultSelector == null)
            {
                throw Error.ArgumentNull("resultSelector");
            }

            TAccumulate result = seed;
            switch (source)
            {
                case TSource[] sa:
                    for (int i = 0; i < sa.Length; i++)
                    {
                        result = func(result, sa[i]);
                    }
                    break;
                case List<TSource> sl:
                    for (int i = 0; i < sl.Count; i++)
                    {
                        result = func(result, sl[i]);
                    }
                    break;
                default:
                    int sourceCount = source.Count;
                    for (int i = 0; i < sourceCount; i++)
                    {
                        result = func(result, source[i]);
                    }
                    break;
            }

            return resultSelector(result);
        }

        // ------------------------------ Spans --------------------------
        #region Normal Span<T>
        /// <summary>
        /// Applies an accumulator function over a Span{T}.
        /// </summary>        
        /// <param name="source">A Span{T} to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSource AggregateF<TSource>(this Span<TSource> source,
            Func<TSource, TSource, TSource> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            if (source.Length == 0)
            {
                throw Error.NoElements();
            }

            TSource result = source[0];
            for (int i = 1; i < source.Length; i++)
            {
                result = func(result, source[i]);
            }
            return result;
        }

        /// <summary>
        /// Applies an accumulator function over a Span{T}. The specified seed
        /// value is used as the initial accumulator value.
        /// </summary>        
        /// <param name="source">A Span{T} to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate AggregateF<TSource, TAccumulate>(this Span<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            TAccumulate result = seed;
            for (int index = 0; index < source.Length; index++)
            {
                result = func(result, source[index]);
            }

            return result;
        }

        /// <summary>
        /// Applies an accumulator function over a Span{T}. The specified seed
        /// value is used as the initial accumulator value, and the specified 
        /// function is used to select the result value.
        /// </summary>        
        /// <param name="source">A Span{T} to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <returns>The transformed final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this Span<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func,
            Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            if (resultSelector == null)
            {
                throw Error.ArgumentNull("resultSelector");
            }

            TAccumulate result = seed;
            for (int index = 0; index < source.Length; index++)
            {
                result = func(result, source[index]);
            }

            return resultSelector(result);
        }
        #endregion Normal Span<T>

        // ------------------------------ ReadOnlySpans --------------------------
        #region ReadOnlySpan<T>
        /// <summary>
        /// Applies an accumulator function over a ReadOnlySpan{T}.
        /// </summary>        
        /// <param name="source">A ReadOnlySpan{T} to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSource AggregateF<TSource>(this ReadOnlySpan<TSource> source, 
            Func<TSource, TSource, TSource> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            if (source.Length == 0)
            {
                throw Error.NoElements();
            }

            TSource result = source[0];
            for (int i = 1; i < source.Length; i++)
            {
                result = func(result, source[i]);
            }
            return result;
        }

        /// <summary>
        /// Applies an accumulator function over a ReadOnlySpan{T}. The specified seed
        /// value is used as the initial accumulator value.
        /// </summary>        
        /// <param name="source">A ReadOnlySpan{T} to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate AggregateF<TSource, TAccumulate>(this ReadOnlySpan<TSource> source, TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            TAccumulate result = seed;
            for (int index = 0; index < source.Length; index++)
            {
                result = func(result, source[index]);
            }

            return result;
        }

        /// <summary>
        /// Applies an accumulator function over a ReadOnlySpan{T}. The specified seed
        /// value is used as the initial accumulator value, and the specified 
        /// function is used to select the result value.
        /// </summary>        
        /// <param name="source">A ReadOnlySpan{T} to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <returns>The transformed final accumulator value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this ReadOnlySpan<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func, 
            Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            if (resultSelector == null)
            {
                throw Error.ArgumentNull("resultSelector");
            }

            TAccumulate result = seed;
            for (int index = 0; index < source.Length; index++)
            {
                result = func(result, source[index]);
            }

            return resultSelector(result);
        }
        #endregion ReadOnlySpan<T>


    }
}