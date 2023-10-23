using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise7
{
    public class ArrayContainer
    {
        private int[] array;

        public ArrayContainer(int[] elements)
        {
            array = elements;
        }

        public static bool operator <(ArrayContainer left, ArrayContainer right)
        {
            if (left == null && right == null)
            {
                return false;
            }

            if (left == null)
            {
                return true;
            }

            if (right == null)
            {
                return false;
            }

            int sumLeft = 0;
            foreach (int element in left.array)
            {
                sumLeft += element;
            }

            int sumRight = 0;
            foreach (int element in right.array)
            {
                sumRight += element;
            }

            return sumLeft < sumRight;
        }

        public static bool operator >(ArrayContainer left, ArrayContainer right)
        {
            if (left == null && right == null)
            {
                return false;
            }

            if (left == null)
            {
                return false;
            }

            if (right == null)
            {
                return true;
            }

            int sumLeft = 0;
            foreach (int element in left.array)
            {
                sumLeft += element;
            }

            int sumRight = 0;
            foreach (int element in right.array)
            {
                sumRight += element;
            }

            return sumLeft > sumRight;
        }
    }
}
