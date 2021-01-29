using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryStructure
{

    // Here a dictionary was created with generics
    // Key and Value can be any type

    class MyDictionary<T1, T2>
    {
        T1[] index; // For Dictionary structure.
        T2[] element;

        public MyDictionary()
        {
            index = new T1[0]; // Defining an allocation for arrays.
            element = new T2[0];
        }

        public void Add(T1 key, T2 value) 
        {
            T1[] tempIndex = index;
            T2[] tempElement = element;

            index = new T1[index.Length + 1];
            element = new T2[element.Length + 1];

            for (int i = 0; i < tempIndex.Length; i++)
            {
                index[i] = tempIndex[i];
                element[i] = tempElement[i];
            }

            index[index.Length - 1] = key;
            element[element.Length - 1] = value;

        }

        public int Length() 
        {
            return index.Length;
        }

    }
}
