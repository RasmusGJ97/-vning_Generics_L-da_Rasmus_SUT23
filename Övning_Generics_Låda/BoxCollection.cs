using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Generics_Låda
{
    internal class BoxCollection : ICollection<Box>
    {
        private new List<Box> innerCollection;
        public BoxCollection() 
        {
            innerCollection = new List<Box>();
        }
        public int Count 
        {
            get
            {
                return innerCollection.Count;
            }
        }

        public Box this[int index]
        {
            get { return (Box)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("Box already exists!");
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Box item)
        {
            foreach (Box box in innerCollection)
            {
                if (box.Equals(item))
                {
                    return true;
                }
            }           
            return false;
            
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool remove = false;

            for (int i = 0; i < innerCollection.Count; i++)
            {
                Box currentBox = innerCollection[i];
                if(new BoxSameProp().Equals(item, currentBox))
                {
                    innerCollection.RemoveAt(i);
                    remove = true;
                    Console.WriteLine("Box removed!");
                    break;
                }
            }
            return remove;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
