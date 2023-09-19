using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Empl01();
            //Empl02();
            //FillArray();
            //Exmpl03();
            //Строка 2 gb, строка ссылочный тип, ссылочный тип равен null
            //Exmpl04();
            Practise06();
        }
        static void Empl01()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }
        static void Empl02()
        {
            int[,] arr = new int[5, 5];
            //arr[0, 0] = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = i + j;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Rank);
        }
        static void FillArray(int[] arr)
        {
            //массив ссылочный тип, работает с копией
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
        }
        static void Exmpl03()
        {
            Console.WriteLine("M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[m];
            int[] arr2 = new int[n];
            int lengthArr = 0; // Изменено на 0, так как начальная длина массива arr3 должна быть 0

            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(0, 3);
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(0, 3);
                Console.Write(arr2[i] + " ");
            }

            // 1 2 3
            // 1 1 1

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    lengthArr++;
                }
            }

            int[] arr3 = new int[lengthArr]; // Создаем массив arr3 с правильной длиной

            int lngArr = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[lngArr++] = arr1[i];
                    }
                }
            }

            for (int i = 0; i < arr3.Length; i++) // Изменено на arr3.Length, чтобы не выйти за пределы массива arr3
            {
                Console.WriteLine(arr3[i]);
            }

        }
        static void Exmpl04()
        {
            string str;
            string str2 = null;
            string str3 = "      ";
            string str4 = new String('-', 60);

            string str5 = "Test";
            char letter = str5[1];
            Console.WriteLine(letter);

            string strA = "Test";
            string strB = "Test";

            int res = string.Compare(strA, strB);
            // if (res == 0)
            if (res.Equals(0))
            {
                Console.WriteLine("Yes");
            }
            if (strA.CompareTo(strB) == 0)
            {
                Console.WriteLine("Yes");
            }
        }
        //Contains содержится ли текст в строке
        static void Exmpl05()
        {
            string strA = "tst asdar test egggf";
            if(strA.Contains("test"))
            {
                Console.WriteLine(true);
            }

            string strB = "asdadsd";
            string strC = strA + strB;
            string strD = string.Concat(strC, strB);

            Console.WriteLine(strB);    
        }
        static void Exmpl06()
        {
            string str = "4003 8327 7395 5051";
            if(str.StartsWith("4003"))
            {
                Console.WriteLine("Visa");
            }
            else if(str.StartsWith("4005"))
            {
                Console.WriteLine("master card");
            }
            string phone = "8 777 952 50 50";
            if(phone.StartsWith("+7"))
            {
                Console.WriteLine("Введите корректно номер!");
            }
        }
        static void Expml07()
        {
            string str = "4003 8327 7395 5051";
            //разделение
            string[] temp = str.Split(' ');

            string strB = string.Join(" ", temp);
            //Trim - удаляет ' ' в начале строки и в конце
            //Replace("1 значение", "2 значение") - замена

            //StringBuilder - занимает больше памяти, работает с ориганалом
        }
        static void Practise06()
        {
            string str = "аббревиатура";
            string str1 = str.Substring(0, 3);
            string str2 = str.Substring(3, 3);
            string str3 = str.Substring(6, 3);
            string res1 = string.Concat(str2, str3, str1);
            string res2 = string.Concat(str3, str1, str2);


            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
        static void Practise07()
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            int counter = 0;
            while()
            {

            }
        }
    }
}
