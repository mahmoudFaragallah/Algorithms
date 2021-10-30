using System;
using System.Collections.Generic;
using System.Text;

namespace dynamicarray
{
    public  class DynamicArray<T> 
    {
        private T[] arr;
        private int len = 0; //Length user thinks array is
        private int capacity = 0; // Actual array size

        // Empty constructor to set default value of arr
        public DynamicArray()
        {
            arr = new T[16];
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException("out of range capacity: " + capacity);
            this.capacity = capacity;
            arr = new T[capacity]; // recreate arr with new capacity
        }

        public int Size()
        {
            return len;
        }

        public Boolean IsEmpty()
        {
            return Size() == 0;
        }
        // get the value of specific index
        public T Get(int index)
        {
            return index < 0 || index > capacity ? throw new IndexOutOfRangeException("This index is out of the range: " + index) : arr[index];
        }
        // set elem value to specific index
        public T Set(int index,T elem)
        {
            return index < 0 || index > capacity ? throw new IndexOutOfRangeException("This index is out of the range: " + index) : arr[index] = elem;
        }
        public void Clear()
        {
            for (int i = 0; i < len; i++)
            {
                arr[i] = default;
            }
            len = 0;
        }
        public Boolean Contains(T[] arr, T elem)
        {
            return Array.Exists(arr, e => e.Equals(elem));
        }
    }
}
