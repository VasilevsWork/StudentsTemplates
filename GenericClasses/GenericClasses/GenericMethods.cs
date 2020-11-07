using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{

    class MyInt : IEquatable<Int32>
    {
        Int32 value;

        public MyInt()
        {

        }

        public MyInt(Int32 val)
        {
            value = val;
        }

        public bool Equals(Int32 other)
        {
            return value.Equals(other);
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }

    struct MyDouble : IEquatable<Double>
    {
        Double value;

        public MyDouble(Double val)
        {
            value = val;
        }

        public bool Equals(Double other)
        {
            return value.Equals(other);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    class GenericExamples 
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void SwapStruct<T>(ref T x, ref T y) where T : struct
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void SwapDoubles<T>(ref T x, ref T y) where T : IEquatable<Double>
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
