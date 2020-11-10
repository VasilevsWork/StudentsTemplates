using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void makeOutput(object obj)
        {
            Console.WriteLine(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeOutput("--- Swap<MyInt> ---");

            MyInt myInt1 = new MyInt(5);
            MyInt myInt2 = new MyInt(4);

            GenericExamples.Swap<MyInt>(ref myInt1, ref myInt2);
            makeOutput(myInt1);
            makeOutput(myInt2);

            makeOutput("--- SwapStruct<MyDouble> ---");

            MyDouble myDouble1 = new MyDouble(10.0);
            MyDouble myDouble2 = new MyDouble(20.0);

            GenericExamples.SwapStruct<MyDouble>(ref myDouble1, ref myDouble2);
            makeOutput(myDouble1);
            makeOutput(myDouble2);

            makeOutput("--- SwapDoubles ---");

            double double1 = 130.0;
            double double2 = 150.0;

            GenericExamples.SwapDoubles<MyDouble>(ref myDouble1, ref myDouble2);
            makeOutput(myDouble1);
            makeOutput(myDouble2);

            GenericExamples.SwapDoubles<double>(ref double1, ref double2);
            makeOutput(double1);
            makeOutput(double2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonsContainer<Student> students = new PersonsContainer<Student>();
            PersonsContainer<Teacher> teachers = new PersonsContainer<Teacher>();
            
            //PersonsContainer<Cat> cats = new PersonsContainer<Cat>(); // ОШИБКА!
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoGenericAccount account1 = new NoGenericAccount { Sum = 5000 };
            NoGenericAccount account2 = new NoGenericAccount { Sum = 4000 };
            account1.Id = 2;                    // упаковка
            account2.Id = "4356";               // упаковка
            int id1 = (int)account1.Id;         // распаковка
            string id2 = (string)account2.Id;   // распаковка
            makeOutput(id1);
            makeOutput(id2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenericAccount<int> account1 = new GenericAccount<int> { Sum = 5000 };
            GenericAccount<string> account2 = new GenericAccount<string> { Sum = 4000 };
            account1.Id = 2;        // упаковка не нужна
            account2.Id = "4356";
            int id1 = account1.Id;  // распаковка не нужна
            string id2 = account2.Id;
            makeOutput(id1);
            makeOutput(id2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<object> list;
            GenericAccount<int> account1 = new GenericAccount<int> { Id = 3, Sum = 5000 };

            

        }
    }
}
