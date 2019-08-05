using System.Runtime.CompilerServices;
// ReSharper disable ForCanBeConvertedToForeach
// ReSharper disable UnusedMember.Global

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        // --------------------------  Arrays --------------------------------------------

        /// <summary>
        /// Returns an array (For speed) with a single value set to default{T}
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns>source or new array{1}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] DefaultIfEmptyF<T>(this T[] source)
        {
            if ((source == null)
                || (source.Length == 0)
                )
            {
                return new T[] { default(T) };
            }
            return source;
        }
    }
}
