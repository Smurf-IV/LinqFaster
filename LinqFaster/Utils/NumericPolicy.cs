using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace JM.LinqFaster.Utils
{
    internal interface INumericPolicy<T>
    {
        T Zero();

        T Add(T a, T b);
    }

    internal interface INumericPolicy<in T1, T2>
        where T1 : IConvertible
    {
        T2 Zero();

        T2 Add(T2 a, T1 b);
    }

    /// <summary>
    /// checked will be done at the for LOOP level
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct NumericPolicies :
        INumericPolicy<byte, uint>,
        INumericPolicy<sbyte, int>,
        INumericPolicy<ushort, uint>,
        INumericPolicy<short, int>,
        INumericPolicy<uint>,
        INumericPolicy<int>,
        INumericPolicy<ulong>,
        INumericPolicy<long>,
        INumericPolicy<float, double>,
        INumericPolicy<double>,
        INumericPolicy<decimal>
    {
        public static NumericPolicies Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint INumericPolicy<byte, uint>.Zero() { return 0U; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint INumericPolicy<byte, uint>.Add(uint a, byte b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int INumericPolicy<sbyte, int>.Zero() { return 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int INumericPolicy<sbyte, int>.Add(int a, sbyte b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint INumericPolicy<ushort, uint>.Zero() { return 0U; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint INumericPolicy<ushort, uint>.Add(uint a, ushort b) { return a + b;}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int INumericPolicy<short, int>.Zero() { return 0;}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int INumericPolicy<short, int>.Add(int a, short b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint INumericPolicy<uint>.Zero() { return 0U; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint INumericPolicy<uint>.Add(uint a, uint b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int INumericPolicy<int>.Zero() { return 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int INumericPolicy<int>.Add(int a, int b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong INumericPolicy<ulong>.Zero() { return 0UL; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong INumericPolicy<ulong>.Add(ulong a, ulong b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long INumericPolicy<long>.Zero() { return 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long INumericPolicy<long>.Add(long a, long b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        double INumericPolicy<float, double>.Zero() { return 0.0F; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        double INumericPolicy<float, double>.Add(double a, float b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        double INumericPolicy<double>.Zero() { return 0.0D; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        double INumericPolicy<double>.Add(double a, double b) { return a + b; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        decimal INumericPolicy<decimal>.Zero() { return new decimal(0, 0, 0, false, 1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        decimal INumericPolicy<decimal>.Add(decimal a, decimal b) { return a + b; }

    }
}
