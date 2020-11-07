using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace FiguresContainer
{
    class Figure
    {
        public int counter;
    }
    class FiguresContainer : IEnumerable<Figure>
    {
        List<Figure> figures = new List<Figure>();

        public void ToXml(string filename)
        {
            XmlWriter writer = XmlWriter.Create(filename);
        }
        public void FromXml(string filename)
        {
            XmlReader reader = XmlReader.Create(filename);
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public Figure GetValue(int index)
        {
            return figures[index];
        }
        
        public int Count
        {
            get
            {
                return figures.Count;
            }
        }

        #region Q1
        public Figure this[int index]
        {
            get
            {
                return GetValue(index);
            }
        }
        #endregion

        #region Q2
        IEnumerator IEnumerable.GetEnumerator()
        {
            return figures.GetEnumerator();
        }

        public IEnumerator<Figure> GetEnumerator()
        {
            return ((IEnumerable<Figure>)figures).GetEnumerator();
        }
        #endregion
    }
}
