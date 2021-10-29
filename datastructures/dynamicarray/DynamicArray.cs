using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.datastructures.dynamicarray
{
    public class DynamicArray<T> 
    {
        private T[] array;
        private int len = 0; //length user thinks array is
        private int capacity = 0; // Actual array size

        
        public DynamicArray()
        {
           // this(16);
        }

    }
}
