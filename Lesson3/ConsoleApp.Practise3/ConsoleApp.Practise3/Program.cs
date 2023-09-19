using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp.Practise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание: Объявить одномерный (5 элементов ) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.");
            Ex1();
            Console.WriteLine("2 задание: Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.");
            Ex2();
            Console.WriteLine("3 задание: Пользователь вводит строку. Проверить, является ли эта строка палиндромом. Палиндромом называется строка, которая одинаково читается слева направо и справа налево.");
            Ex3();
            Console.WriteLine("4 задание: Подсчитать количество слов во введенном предложении.");
            Ex4();
            Console.WriteLine("5 задание: Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.");
            Ex5();
            Console.WriteLine("6 задание: Дан текст. Найти наибольшее количество идущих подряд одинаковых символов");
            Ex6();
            Console.WriteLine("7 задание: Составить программу, которая подсчитывает, сколько содержится цифр в строке длиной 20 символов.");
            Ex7();
            Console.WriteLine("8 задание: Дан текст, состоящий из 20 букв. Проверить, можно ли из заданной последовательности символов составить Ваше имя и напечатать его. В противном случае напечатать текст “Нет имени”.");
            Ex8();
            Console.WriteLine("9 задание: Дана строка символов длиной не более 255 символов. Группы символов, разделенные пробелами и не содержащие пробелов внутри себя, будем называть словами. Найти количество слов, у которых первый и последний символы совпадают между собой.");
            Ex9();
            Console.WriteLine("10 задание: Написать программу, в которой по малой русской букве выводится соответствующая большая.");
            
            Console.WriteLine("-------------СТРОКИ-------------");
            Console.WriteLine("1. Дано слово из 12 букв. Поменять местами его трети следующим образом:\r\n\r\nа) первую треть слова разместить на месте третьей, вторую треть — на месте\r\n\r\nпервой, третью треть — на месте второй;\r\n\r\nб) первую треть слова разместить на месте второй, вторую треть — на месте\r\n\r\nтретьей, третью треть — на месте первой.");
            ExStr1();
            Console.WriteLine("2. Дан текст. Подсчитать общее число вхождений в него символов \"+\" и \"–\".")
            ExStr2();
            Console.WriteLine("3. Дан текст. Определить, сколько в нем предложений.");
            ExStr3();
        }
        static void Ex1()
        {
            Random rnd = new Random();

            int[] A = new int[5];
            int[,] B = new int[3, 4];


            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Введите число в массив " + i + " : ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rnd.Next(0, 10);
                }
            }
            Console.WriteLine("Вывести на экран значения массивов: массива А в одну строку");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("массива В — в виде матрицы");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Общий максимальный элемент");
            int maxInArr1 = 0;
            int maxInArr2 = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxInArr1)
                {
                    maxInArr1 = A[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > maxInArr2)
                    {
                        maxInArr2 = B[i, j];
                    }
                }
            }

            if (maxInArr1 == maxInArr2)
            {
                Console.WriteLine("Общий макс элемент: " + maxInArr1);
            }
            else
            {
                Console.WriteLine("общего макс элемента нет");
            }

            Console.WriteLine("Общий минимальный элемент");
            int minInArr1 = 99999999;
            int minInArr2 = 99999999;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < minInArr1)
                {
                    minInArr1 = A[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] < minInArr2)
                    {
                        minInArr2 = B[i, j];
                    }
                }
            }

            if (minInArr1 == minInArr2)
            {
                Console.WriteLine("Общий мин элемент: " + minInArr1);
            }
            else
            {
                Console.WriteLine("общего мин элемента нет");
            }
            Console.WriteLine("Общая сумма всех элементов");
            int sumArr1 = 0;
            int sumArr2 = 0;
            for (int i = 0; i < A[i]; i++)
            {
                sumArr1 += A[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumArr2 += B[i, j];
                }
            }

            if (sumArr1 == sumArr2)
            {
                Console.WriteLine("Общая сумма: " + sumArr2);
            }
            else
            {
                Console.WriteLine("Общей сумма нет");
            }

            Console.WriteLine("общее произведение всех элементов");
            int multiInArr1 = 0;
            int multiInArr2 = 0;
            for (int i = 0; i < A[i]; i++)
            {
                multiInArr1 *= A[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    multiInArr2 *= B[i, j];
                }
            }

            if (multiInArr1 == multiInArr2)
            {
                Console.WriteLine("Общее произведение: " + multiInArr2);
            }
            else
            {
                Console.WriteLine("Общего произведение нет");
            }
            Console.WriteLine("сумму четных элементов массива А, сумму нечетных столбцов массива В");
            int sumInArr1 = 0;
            int sumInArr2 = 0;
            for (int i = 0; i < A[i]; i++)
            {
                if (i % 2 == 0)
                {
                    sumInArr1 += A[i];
                }
                
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 == 0)
                    {
                        sumInArr2 += B[i, j];
                    }
                }
            }

           Console.WriteLine();
           Console.WriteLine("сумма четных элементов массива А: " + sumInArr1);
           Console.WriteLine("сумма нечетных столбцов массива В: " + sumInArr2);

        }
        static void Ex2()
        {
            Random rnd = new Random();
            Console.Write("Размер массива m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Размер массива n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[m];
            int[] arr2 = new int[n];



            int cnt = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(-10, 10);
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(-10, 10);
                Console.Write(arr2[i] + " ");
            }

            for (int i = 0; i < m; i++)
            {
                bool found = false;
                for (int j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j] && !found)
                    {
                        cnt++;
                        found = true;
                    }
                }
            }

            int[] arr3 = new int[cnt];
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                bool found = false;
                for (int j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j] && !found)
                    {
                        arr3[k++] = arr1[i];
                        found= true;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("3 матрица: ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
        static void Ex3()
        {
            Console.Write("Введите текст: ");
            string textInput = Console.ReadLine();
            
            string textLowerCase = textInput.ToLower();

            int maxLentgh = textLowerCase.Length - 1;
            bool flagIsPalindrome = false;

            for (int i = 0; i < maxLentgh / 2; i++)
            {
                if (textLowerCase[i] == textLowerCase[maxLentgh--])
                {
                    flagIsPalindrome = true;
                }
            }

            if (flagIsPalindrome) { Console.WriteLine("Слово палиндром!"); }
            else { Console.WriteLine("Слово не палиндром!"); }
        }
        static void Ex4()
        {
            Console.WriteLine("Введите предложение: ");
            string texts = Console.ReadLine();
            string[] words = texts.Split(' ');

            Console.WriteLine("Всего слов: " + words.Length);
           
        }
        static void Ex5()
        {
            Random rnd = new Random();
            int[,] arr = new int[5,5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(-100, 101);
                }
            }

            int maxInArr = arr[0, 0];
            int minInArr = arr[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] > maxInArr)
                    {
                        maxInArr = arr[i, j];
                    }
                    if (arr[i, j] < minInArr)
                    {
                        minInArr = arr[i, j];
                    }
                }
            }

            int sum = 0;
            bool foundMin = false;
            bool foundMax = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] == minInArr)
                    {
                        foundMin = true;
                    }

                    if (foundMin)
                    {
                        sum += arr[i, j];
                    }

                    if (arr[i, j] == maxInArr)
                    {
                        foundMax = true;
                        break;
                    }
                }

                if (foundMax)
                {
                    break;
                }
            }
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Макс элемент: " + maxInArr);
            Console.WriteLine("Мин элемент: " + minInArr);
            Console.WriteLine("Сумма элементов: " + sum);
        }
        static void Ex6() 
        {
            Console.WriteLine("Введите текст: ");
            string texts = Console.ReadLine();

            int counter = 0;
            int maxCounter = 0;

            for (int i = 0; i < texts.Length - 1; i++)
            {
                if (texts[i] == texts[i + 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }   

            Console.WriteLine(counter+1);
        }
        static void Ex7()
        {
            string texts = "He11o,World!12345678";

            int counter = 0;
            foreach(char c in texts)
            {
                if(char.IsDigit(c))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Ex8()
        {
            string texts = "Hello, It is a DotNET!";
            string myName = "Ilias";

            string textsLower = texts.ToLower();
            string myNameLower = myName.ToLower();

            bool NameInText = true;

            foreach (char c in myNameLower)
            {
                if (!textsLower.Contains(c))
                {
                    NameInText = false;
                    break;
                }
            }

            if (NameInText) { Console.WriteLine("Есть имя в тексте!");  }
            else { Console.WriteLine("Нет имени"); }
        }
        static void Ex9()
        {
            string texts = Console.ReadLine();

            string[] words = texts.Split(' ');
            int counter = 0;

            foreach (string word in words)
            {
                if (word.Length >= 2 && word[0] == word[word.Length - 1])
                {
                    count++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Ex10()
        {
            Console.WriteLine("Введите текст: ");
            string texts = Console.ReadLine();

            Console.WriteLine(texts.ToUpper());
        }
        static void ExStr1()
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
        static void ExStr2()
        {
            Console.WriteLine("Введите текст:");
            string texts = Console.ReadLine();

            int plusCounter = 0;
            int minusCounter = 0;

            foreach (char c in texts)
            {
                if (c == '+')
                {
                    plusCounter++;
                }
                else if (c == '–') // Обратите внимание, что это длиное тире, не минус (замените его при необходимости)
                {
                    minusCounter++;
                }
            }

            Console.WriteLine("Количество символов '+' в тексте: " + plusCounter);
            Console.WriteLine("Количество символов '–' в тексте: " + minusCounter);
        }
        static void ExStr3()
        {
            Console.WriteLine("Введите текст: ");
            string texts = Console.ReadLine();

            char[] SetChar = { '.', '?', '!'};
            int counter = 0;

            foreach (char c in SetChar)
            {
                counter += texts.Split(SetChar).Length - 1;
            }

            Console.WriteLine("Количество предложений в тексте: " + counter);
        }
    }
}
