using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiguresContainer container = new FiguresContainer();

            for (int i = 0; i < 10; ++i)
            {
                Figure f = new Figure();
                f.counter = i;
                container.Add(f);
            }

            string firstSum = "";
            for (int i = 0; i < container.Count; ++i)
            {
                Figure f = container[i];
                firstSum += f.counter.ToString() + ", ";
            }

            string secondSum = "";
            foreach (Figure f in container)
            {
                secondSum += f.counter.ToString() + ", ";
            }

            textBox1.Text = firstSum;
            textBox2.Text = secondSum;
        }
    }
}
