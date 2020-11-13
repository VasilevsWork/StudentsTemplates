using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace FiguresContainer
{
    class DummyObject
    {
        public int counter;
    }
    class DummyContainer : IEnumerable<DummyObject>
    {
        public delegate void ObjectAddDelegate(DummyObject f);

        public ObjectAddDelegate NotifyDelegate { get; set; }
        public event ObjectAddDelegate NotifyEvent;

        List<DummyObject> figures = new List<DummyObject>();

        public void ToXml(string filename)
        {
            XmlWriter writer = XmlWriter.Create(filename);
        }
        public void FromXml(string filename)
        {
            XmlReader reader = XmlReader.Create(filename);
        }

        public void Add(DummyObject figure)
        {
            figures.Add(figure);
            //AddedDelegate(figure);
            NotifyEvent?.Invoke(figure);
        }

        public DummyObject GetValue(int index)
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
        public DummyObject this[int index]
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

        public IEnumerator<DummyObject> GetEnumerator()
        {
            return ((IEnumerable<DummyObject>)figures).GetEnumerator();
        }
        #endregion
    }
}
