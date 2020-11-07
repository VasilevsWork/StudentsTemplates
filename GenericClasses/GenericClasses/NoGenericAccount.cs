using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class GenericAccount<T>
    {
        public T Id { get; set; }
        public int Sum { get; set; }
    }

    class NoGenericAccount
    {
        public object Id { get; set; }
        public int Sum { get; set; }
    }
}
