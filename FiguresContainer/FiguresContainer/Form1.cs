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

        DummyContainer container = new DummyContainer();

        /// <summary>
        /// Заполнение контейнера
        /// </summary>
        void fillContainer()
        {
            for (int i = 0; i < 10; ++i)
            {
                DummyObject f = new DummyObject();
                f.counter = i;
                container.Add(f);
            }
        }

        /// <summary>
        /// Вывод всего содержимого с помощью индексатора []
        /// </summary>
        void showInTextBoxWithIndexer()
        {
            string str = "";
            for (int i = 0; i < container.Count; ++i)
            {
                DummyObject f = container[i];
                str += f.counter.ToString() + ", ";
            }

            textBox1.Text = str;
        }

        /// <summary>
        /// Вывод всего содержимого с помощью foreach
        /// </summary>
        void showInTextBoxWithForeach()
        {
            string secondSum = "";
            foreach (DummyObject f in container)
            {
                secondSum += f.counter.ToString() + ", ";
            }

            textBox2.Text = secondSum;
        }

        /// <summary>
        /// Подписка на добавление в контейнер через делегат
        /// </summary>
        void SetDelegates()
        {
            container.NotifyDelegate += OnAddFirst;
            container.NotifyDelegate += OnAddSecond;

            // Пример того, что можно вызывать делегат вручную.

            //Figure tmpFigure = new Figure();
            //tmpFigure.counter = 100;
            //container.AddedDelegate(tmpFigure);
        }

        /// <summary>
        /// Подписка на добавление в контейнер через события
        /// </summary>
        void SetEvents()
        {
            container.NotifyEvent += OnAddFirst;
            container.NotifyEvent += OnAddFirst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillContainer();
        }

        /// <summary>
        /// Добавляет текст добавленного объекта в первое текстовое поле.
        /// </summary>
        /// <param name="f">Добавленный объект</param>
        void OnAddFirst(DummyObject f)
        {
            textBox1.Text += " " + f.counter.ToString();
        }

        /// <summary>
        /// Добавляет текст добавленного объекта во второе текстовое поле.
        /// </summary>
        /// <param name="f">Добавленный объект</param>
        void OnAddSecond(DummyObject f)
        {
            textBox2.Text += " " + f.counter.ToString();
        }
    }
}
