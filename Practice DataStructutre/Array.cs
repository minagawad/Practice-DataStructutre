using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DataStructutre
{
    public class Array<T> : IEnumerable<T>
    {
        private T[] array;
        private int len = 0;
        private int capacity = 0;

        public Array()
        {
            this.array = new T[16];
        }

        public Array(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("illegal capacity" + capacity);
            this.capacity = capacity;
            array = new T[capacity];

        }

        public int size()

        {
            return this.len;

        }
        public bool IsEmpty() => size() == 0;


        public T Get(int index) => array[index];
        public void Set(int inde, T elemnt) => array[inde] = elemnt;

        public void clear()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default(T);
            }
            len = 0;
        }

        public void AAdd(T element)
        {
            if (len + 1 >= capacity)
            {
                if (capacity == 0) capacity = 1;
                else capacity *= 2;
                T[] new_arr = new T[capacity];
                for (int i = 0; i < len; i++)
                {
                    new_arr[i] = array[i];


                }

                array = new_arr;

            }
            array[len++] = element;
        }

        public T RemoveAt(int elementIndex)
        {

            if (elementIndex >= len || elementIndex < 0) throw new IndexOutOfRangeException();
            T data = array[elementIndex];
            T[] new_arr = new T[len - 1];
            for (int i = 0, j = 0; i < len; i++, j++)
            {
                if (i == elementIndex)
                { j--; }

                else
                {
                    new_arr[j]= array[i];
                }

            }
            array=new_arr;
            capacity = --len;
            return data;

        }
       public bool Remove(object obj)
        {

            for (int i=0; i<len; i++)
            {
                if (array[i].Equals(obj))
                {

                    RemoveAt(i);
                    return true;
                }

            }
            return false;
        }
        public int IndexOf(object obj)
        {

            for (int i = 0; i < len; i++)
            {
                if (array[i].Equals(obj))
                    return i;

            }
            return -1;

        }

        public bool Contains(object obj)
        {
            return IndexOf(obj) != -1;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in array)
            {
                if (item==null)
                {
                    break;
                }
                yield return item;

            }


        }


        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }

        public override string ToString()
        {

            if (len == 0) return "[]";
            else
            {
                StringBuilder stringBuilder = new StringBuilder(len).Append('[');
                for(int i=0; i<len-1; i++)
                {
                    stringBuilder.Append(array[i]+",");

                }
                return stringBuilder.Append(array[len - 1] + "]").ToString();

            }
        }
    }
}
