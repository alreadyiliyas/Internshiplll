using System;
using System.Collections.Generic;

namespace ClassLibrary.Practise7
{
    public class MyArray
    {
        private List<int> array;

        public MyArray(params int[] elements)
        {
            array = new List<int>(elements);
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Count)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
            }
            set
            {
                if (index >= 0 && index < array.Count)
                {
                    array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
            }
        }

        public int Length
        {
            get { return array.Count; }
        }

        public static MyArray operator *(MyArray array1, MyArray array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Массивы должны быть одинаковой длины для умножения.");
            }

            int length = array1.Length;
            MyArray result = new MyArray();

            for (int i = 0; i < length; i++)
            {
                result.array.Add(array1[i] * array2[i]);
            }

            return result;
        }

        public static bool operator ==(MyArray array1, MyArray array2)
        {
            if (ReferenceEquals(array1, array2))
            {
                return true;
            }

            if (ReferenceEquals(array1, null) || ReferenceEquals(array2, null))
            {
                return false;
            }

            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(MyArray array1, MyArray array2)
        {
            return !(array1 == array2);
        }

        public static bool operator <=(MyArray array1, MyArray array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Массивы должны быть одинаковой длины для сравнения.");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator >=(MyArray array1, MyArray array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Массивы должны быть одинаковой длины для сравнения.");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
