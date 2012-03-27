using System;
using System.Collections.Generic;

namespace _List
{
    class _ListS<T>
    {
        T[] BaseArray;
        int Indx;
        int Size;

        public _ListS(int size)
        {
            BaseArray = new T[size];
            this.Size = size;
            Indx = 0;
        }

        public T this[int index]
        {
            // This is the get accessor. 
            get
            {
                return BaseArray[index];
            }

            // This is the set accessor. 
            set
            {
                BaseArray[index] = value;
            }
        }

        public void InsertAt(int i, T item)
        {
            T[] tmpArr = new T[Size];
            //скопировать в tmpArr от 0 до indx, затем item, затем от i + 1 до Indx
        }

        public void Insert(int indx)
        {

        }

        public void RemoveAt(int indx, T item)
        {

        }

        public void Remove(int indx)
        {

        }

        public void Clear()
        {

        }

        public void Fill(T item)
        {

        }
    }
}