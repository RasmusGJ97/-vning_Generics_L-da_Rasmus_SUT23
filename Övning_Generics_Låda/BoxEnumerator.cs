using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Generics_Låda
{
    internal class BoxEnumerator:IEnumerator<Box>
    {
        private BoxCollection _box;
        private int _boxIndex;
        private Box _currentBox;

        public BoxEnumerator(BoxCollection box)
        {
            _box = box;
            _boxIndex = -1;
            _currentBox = default(Box);
        }

        public Box Current
        {
            get { return _currentBox; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        void IEnumerator.Reset()
        {
            _boxIndex = -1;
        }

        public bool MoveNext()
        {
            if (++_boxIndex >= _box.Count)
            {
                return false;
            }
            else
            {
                _currentBox = _box[_boxIndex];
            }
            return true;
        }

        public void Dispose()
        {
            
        }

        public int count
        {
            get { return _box.Count; }
        }
    }

    
}
