using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
// ReSharper disable ForCanBeConvertedToForeach
// ReSharper disable UnusedMember.Global

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {

        // --------------------------  Arrays --------------------------------------------

        /// <summary>
        /// Returns the first element of an array.
        /// </summary>        
        /// <param name="source">The array to return the first element of.</param>
        /// <returns>The first element in the specified array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this T[] source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Length == 0)
            {
                throw Error.NoElements();
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element in an array that satisfies a specified condition.
        /// </summary>        
        /// <param name="source">An array to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>The first element that satisfies the condition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (predicate == null)
            {
                throw Error.ArgumentNull(nameof(predicate));
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    return source[i];
                }
            }

            throw Error.NoMatch();
        }

        /// <summary>
        /// Returns the first element of an array, or a default value if the
        /// array contains no elements.
        /// </summary>             
        /// <param name="source">The array to return the first element of.</param>
        /// <returns>default value if source is empty, otherwise, the first element
        /// in source.</returns>        
        public static T FirstOrDefaultF<T>(this T[] source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Length == 0)
            {
                return default(T);
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or a 
        /// default value if no such element is found.
        /// </summary>        
        /// <param name="source">An IEnumerable to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (predicate == null)
            {
                throw Error.ArgumentNull(nameof(predicate));
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (predicate(source[i]))
                {
                    return source[i];
                }
            }

            return default(T);
        }

        /// <summary>
        /// Returns the first element of an Array / List / IList.
        /// </summary>        
        /// <param name="source">The array to return the first element of.</param>
        /// <returns>The first element in the specified array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this IList<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Count == 0)
            {
                throw Error.NoElements();
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element in an array / List / IList that satisfies a specified condition.
        /// </summary>        
        /// <param name="source">An IList to return an element from.</param>
        /// <param name="func">A function to test each element for a condition.</param>
        /// <returns>The first element that satisfies the condition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this IList<T> source, Func<T, bool> func)
        {
            if (func == null)
            {
                throw Error.ArgumentNull(nameof(func));
            }

            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case T[] sa:
                    return sa.FirstF(func);
                default:
                    {
                        int sourceCount = source.Count;
                        for (int i = 0; i < sourceCount; i++)
                        {
                            if (func(source[i]))
                            {
                                return source[i];
                            }
                        }

                        break;
                    }
            }

            throw Error.NoMatch();
        }

        /// <summary>
        /// Returns the first element of an array, or a default value if the
        /// array contains no elements.
        /// </summary>             
        /// <param name="source">The array to return the first element of.</param>
        /// <returns>default value if source is empty, otherwise, the first element
        /// in source.</returns>        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this IList<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Count == 0)
            {
                return default(T);
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or a 
        /// default value if no such element is found.
        /// </summary>        
        /// <param name="source">An IEnumerable to return an element from.</param>
        /// <param name="func">A function to test each element for a condition.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this IList<T> source, Func<T, bool> func)
        {
            if (func == null)
            {
                throw Error.ArgumentNull(nameof(func));
            }

            switch (source)
            {
                case null:
                    throw Error.ArgumentNull(nameof(source));
                case T[] sa:
                    return sa.FirstOrDefaultF(func);
                default:
                    {
                        int sourceCount = source.Count;
                        for (int i = 0; i < sourceCount; i++)
                        {
                            if (func(source[i]))
                            {
                                return source[i];
                            }
                        }

                        break;
                    }
            }

            return default(T);
        }

        // --------------------------  Lists --------------------------------------------

        /// <summary>
        /// Returns the first element of a list
        /// </summary>        
        /// <param name="source">The list to return the first element of.</param>
        /// <returns>The first element in the specified list.</returns>   
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this List<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Count == 0)
            {
                throw Error.NoElements();
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element in a list that satisfies a specified condition.
        /// </summary>        
        /// <param name="source">An list to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>The first element in the list that satisfies the condition.</returns>       
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this List<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (predicate == null)
            {
                throw Error.ArgumentNull(nameof(predicate));
            }

            int sourceCount = source.Count;
            for (int i = 0; i < sourceCount; i++)
            {
                if (predicate(source[i]))
                {
                    return source[i];
                }
            }

            throw Error.NoMatch();
        }

        /// <summary>
        /// Returns the first element of an array, or a default value if the
        /// array contains no elements.
        /// </summary>             
        /// <param name="source">The array to return the first element of.</param>
        /// <returns>default value if source is empty, otherwise, the first element
        /// in source.</returns>      
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this List<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Count == 0)
            {
                return default(T);
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or a 
        /// default value if no such element is found.
        /// </summary>        
        /// <param name="source">An IEnumerable to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this List<T> source, Predicate<T> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (predicate == null)
            {
                throw Error.ArgumentNull(nameof(predicate));
            }

            int sourceCount = source.Count;
            for (int i = 0; i < sourceCount; i++)
            {
                if (predicate(source[i]))
                {
                    return source[i];
                }
            }
            return default(T);
        }

        // --------------------------  Span --------------------------------------------
        #region Normal Span
        /// <summary>
        /// Returns the first element of an Span.
        /// </summary>        
        /// <param name="source">The Span to return the first element of.</param>
        /// <returns>The first element in the specified array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Length == 0)
            {
                throw Error.NoElements();
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element in an Span that satisfies a specified condition.
        /// </summary>        
        /// <param name="source">An Span to return an element from.</param>
        /// <param name="func">A function to test each element for a condition.</param>
        /// <returns>The first element that satisfies the condition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this Span<T> source, Func<T, bool> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull(nameof(func));
            }

            int sourceCount = source.Length;
            for (int i = 0; i < sourceCount; i++)
            {
                if (func(source[i]))
                {
                    return source[i];
                }
            }

            throw Error.NoMatch();
        }

        /// <summary>
        /// Returns the first element of an Span, or a default value if the
        /// array contains no elements.
        /// </summary>             
        /// <param name="source">The Span to return the first element of.</param>
        /// <returns>default value if source is empty, otherwise, the first element
        /// in source.</returns>        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this Span<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Length == 0)
            {
                return default(T);
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or a 
        /// default value if no such element is found.
        /// </summary>        
        /// <param name="source">An Span to return an element from.</param>
        /// <param name="func">A function to test each element for a condition.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this Span<T> source, Func<T, bool> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull(nameof(func));
            }

            foreach (T a in source)
            {
                if (func(a))
                {
                    return a;
                }
            }

            return default(T);
        }
        #endregion Normal Span

        #region ReadOnlySpan
        /// <summary>
        /// Returns the first element of an ReadOnlySpan.
        /// </summary>        
        /// <param name="source">The ReadOnlySpan to return the first element of.</param>
        /// <returns>The first element in the specified array.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this ReadOnlySpan<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Length == 0)
            {
                throw Error.NoElements();
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element in an ReadOnlySpan that satisfies a specified condition.
        /// </summary>        
        /// <param name="source">An ReadOnlySpan to return an element from.</param>
        /// <param name="func">A function to test each element for a condition.</param>
        /// <returns>The first element that satisfies the condition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstF<T>(this ReadOnlySpan<T> source, Func<T, bool> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull(nameof(func));
            }

            foreach (T a in source)
            {
                if (func(a))
                {
                    return a;
                }
            }

            throw Error.NoMatch();
        }

        /// <summary>
        /// Returns the first element of an ReadOnlySpan, or a default value if the
        /// array contains no elements.
        /// </summary>             
        /// <param name="source">The ReadOnlySpan to return the first element of.</param>
        /// <returns>default value if source is empty, otherwise, the first element
        /// in source.</returns>        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this ReadOnlySpan<T> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }
            if (source.Length == 0)
            {
                return default(T);
            }
            return source[0];
        }

        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or a 
        /// default value if no such element is found.
        /// </summary>        
        /// <param name="source">An ReadOnlySpan to return an element from.</param>
        /// <param name="func">A function to test each element for a condition.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefaultF<T>(this ReadOnlySpan<T> source, Func<T, bool> func)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (func == null)
            {
                throw Error.ArgumentNull(nameof(func));
            }

            foreach (T a in source)
            {
                if (func(a))
                {
                    return a;
                }
            }

            return default(T);
        }
        #endregion ReadOnlySpan

    }
}
