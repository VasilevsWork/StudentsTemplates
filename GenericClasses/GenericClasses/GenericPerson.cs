using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Cat
    {

    }

    class Person
    {

    }

    class Student : Person
    {

    }

    class Teacher : Person
    {

    }

    class PersonsContainer<T> where T : Person
    {
    }
}
