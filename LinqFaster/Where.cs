﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFaster
{
    public static class WhereFuncs
    {
        // --------------------------  ARRAYS --------------------------------------------

        public static T[] Where<T>(this T[] a, Func<T,bool> predicate)
        {            
            List<T> temp = new List<T>();
            for (int i = 0; i < a.Length;i++)
            {
                if (predicate.Invoke(a[i])) temp.Add(a[i]);
            }
            return temp.ToArray();
        }

        public static T[] Where<T>(this T[] a, Func<T,int, bool> predicate)
        {
            List<T> temp = new List<T>();
            for (int i = 0; i < a.Length; i++)
            {
                if (predicate.Invoke(a[i],i)) temp.Add(a[i]);
            }
            return temp.ToArray();
        }

        // --------------------------  LISTS --------------------------------------------

        public static List<T> Where<T>(this List<T> a, Func<T, bool> predicate)
        {
            List<T> r = new List<T>();
            for (int i = 0; i < a.Count ; i++)
            {
                if (predicate.Invoke(a[i])) r.Add(a[i]);
            }
            return r;
        }

        public static List<T> Where<T>(this List<T> a, Func<T, int, bool> predicate)
        {
            List<T> r = new List<T>();
            for (int i = 0; i < a.Count; i++)
            {
                if (predicate.Invoke(a[i], i)) r.Add(a[i]);
            }
            return r;
        }






    }
}