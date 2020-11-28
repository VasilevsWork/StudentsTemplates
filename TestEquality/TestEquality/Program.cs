using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest();
        }

        static void ClassTest()
        {
            TestClass obj1 = new TestClass
            {
                Count = 10
            };

            IEquatable<int> obj2 = new TestClass
            {
                Count = 10
            };

            TestClass obj3 = obj1;

            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj2.Equals(10));
            Console.WriteLine(object.Equals(obj1, obj2));
            Console.WriteLine(object.ReferenceEquals(obj1, obj3));
            Console.ReadKey();
        }

        static void StructureTest()
        {
            TestStruct str1;
            str1.Count = 10;
            str1.Other = 0.0;

            TestStruct str2;
            str2.Count = 10;
            str2.Other = 0.0;

            TestStruct str3 = str1;
            //str3.Count = 12;

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(object.ReferenceEquals(str1, str1));
            Console.ReadKey();
        }

    }

    struct TestStruct : IEquatable<TestStruct>, IEquatable<TestClass>, IEquatable<Int32>, IComparable<TestStruct>
    {
        public int Count;
        public double Other;

        public override bool Equals(object obj)
        {
            if (obj is TestStruct objectType)
            {
                return this.Count == objectType.Count;
            }
            return false;
        }

        bool IEquatable<TestStruct>.Equals(TestStruct other)
        {
            return this.Count == other.Count;
        }

        bool IEquatable<TestClass>.Equals(TestClass other)
        {
            return this.Count == other.Count;
        }

        public int CompareTo(TestStruct other)
        {
            return this.Count.CompareTo(other.Count);
        }

        bool IEquatable<int>.Equals(int other)
        {
            return this.Count == other;
        }

        public static bool operator !=(TestStruct s, TestStruct other)
        {
            return s.Count != other.Count;
        }

        public static bool operator ==(TestStruct s, TestStruct other)
        {
            return s.Count == other.Count;
        }
    }


    class TestClass : IEquatable<Int32>
    {
        public int Count { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is TestClass objectType)
            {
                return this.Count == objectType.Count;
            }

            return false;
        }

        bool IEquatable<int>.Equals(int other)
        {
            return this.Count == other;
        }
    }
}
