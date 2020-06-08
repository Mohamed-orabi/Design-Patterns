using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    class JellyBean
    {
        private string _flavor;

        public JellyBean(string flavor)
        {
            this._flavor = flavor;
        }

        public string Flavor
        {
            get
            {
                return _flavor;
            }
        }
    }

    interface ICandyCollection
    {
        JellyBeanIterator CreateIterator();
    }


    class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _item = new ArrayList();

        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }
        public int count
        {
            get
            {
                return _item.Count;
            }
        }

        public object this[int index]
        {
            get
            {
                return _item[index];
            }
            set
            {
                _item.Add(value);
            }
        }
    }


    interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();
        bool IsDone { get; }
        JellyBean CurrentBeans { get; }
    }


    class JellyBeanIterator : IJellyBeanIterator
    {
        private JellyBeanCollection _jellyBeanCollection;
        private int _current = 0;
        private int _step = 1;

        public JellyBeanIterator(JellyBeanCollection jellyBeanCollection)
        {
            this._jellyBeanCollection = jellyBeanCollection;
        }

        public JellyBean First()
        {
            _current = 0;
            return _jellyBeanCollection[_current] as JellyBean;
        }

        public JellyBean Next()
        {
            _current += _step;
            if (!IsDone)
                return _jellyBeanCollection[_current] as JellyBean;
            else
                return null; 
        }

        public JellyBean CurrentBeans
        {
            get
            {
                return _jellyBeanCollection[_current] as JellyBean;
                    
            }
        }

        public bool IsDone
        {
            get
            {
                return _current >= _jellyBeanCollection.count;
            }
        }
    }
}
