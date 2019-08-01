using System;
using System.Collections.Generic;
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

        // ------------------------------ Arrays --------------------------

        /// <summary>
        /// Applies an accumulator function over an array.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        public static TSource AggregateF<TSource>(this IList<TSource> source, 
            Func<TSource, TSource, TSource> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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
        /// Applies an accumulator function over an array. The specified seed
        /// value is used as the initial accumulator value.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        public static TAccumulate AggregateF<TSource, TAccumulate>(this IList<TSource> source, TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }

            if (func == null)
            {
                throw Error.ArgumentNull("func");
            }

            TAccumulate result = seed;
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
        /// Applies an accumulator function over an array. The specified seed
        /// value is used as the initial accumulator value, and the specified 
        /// function is used to select the result value.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <returns>The transformed final accumulator value</returns>
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this IList<TSource> source, TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func, 
            Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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

            return resultSelector(result);
        }

        // ------------------------------ this Spans --------------------------
        #region Normal Span<T>
        /// <summary>
        /// Applies an accumulator function over an array.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        public static TSource AggregateF<TSource>(this Span<TSource> source,
            Func<TSource, TSource, TSource> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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
        /// Applies an accumulator function over an array. The specified seed
        /// value is used as the initial accumulator value.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        public static TAccumulate AggregateF<TSource, TAccumulate>(this Span<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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
        /// Applies an accumulator function over an array. The specified seed
        /// value is used as the initial accumulator value, and the specified 
        /// function is used to select the result value.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <returns>The transformed final accumulator value</returns>
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this Span<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func,
            Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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

        // ------------------------------ this ReadOnlySpans --------------------------
        #region ReadOnlySpan<T>
        /// <summary>
        /// Applies an accumulator function over an array.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        public static TSource AggregateF<TSource>(this ReadOnlySpan<TSource> source, 
            Func<TSource, TSource, TSource> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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
        /// Applies an accumulator function over an array. The specified seed
        /// value is used as the initial accumulator value.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <returns>The final accumulator value</returns>
        public static TAccumulate AggregateF<TSource, TAccumulate>(this ReadOnlySpan<TSource> source, TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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
        /// Applies an accumulator function over an array. The specified seed
        /// value is used as the initial accumulator value, and the specified 
        /// function is used to select the result value.
        /// </summary>        
        /// <param name="source">An array to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <returns>The transformed final accumulator value</returns>
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this ReadOnlySpan<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func, 
            Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
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