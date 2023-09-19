using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp.Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Напечатать весь массив целых чисел");
            Ex1();
            Console.WriteLine("2. Найти индекс максимального значения в массив");
            Ex2();
            Console.WriteLine("3. Найти индекс максимального четного значения в массиве");
            Ex3();
            Console.WriteLine("4. Удалить элемент из массива по индекс");
            Ex4();
            Console.WriteLine("5. Удаление элементов из массива по значению");
            Ex5();
            Console.WriteLine("6. Вставить элемент в массив по индекс");
            Ex6();
            Console.WriteLine("7. Удалить те элементы массива, которые встречаются в нем ровно два раза");
            Ex7();
            Console.WriteLine("8. Дан текст. Определить, есть ли в тексте слово one");
            Ex8();
            Console.WriteLine("9. Дан текст. Определить, содержит ли он символы, отличающиеся от букв и цифр");
            Ex9();
            Console.WriteLine("10. Ввести небольшой текст (с пробелами) в строку S. Подсчитать количество слов в строке и вывести все слова в столбик.");
            Ex10();
            Console.WriteLine("11. Составьте программу, которая в слове «класс» две одинаковые буквы заменяет цифрой «1");
            Ex11();
            Console.WriteLine("12. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.");
            Ex12();
            Console.WriteLine("13. Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.");
            Ex13();
            Console.WriteLine("14. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов. (Подсказка. IF, Length)");
            Ex14();
            Console.WriteLine("15. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).");
            Ex15();
        }
        static void Ex1()
        {
            Console.Write("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Ex2()
        {
            Random rnd = new Random();
            Console.Write("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }

            Console.WriteLine("Max: " + arr.Max());
        }
        static void Ex3()
        {
            Random rnd = new Random();
            Console.Write("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[n];
            int counter = 0;


            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                }
            }
            int[] arrEvenElements = new int[counter];
            int evenIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrEvenElements[evenIndex] = arr[i];
                    evenIndex++;
                }
            }

            int maxInArr = arrEvenElements.Max();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == maxInArr)
                {
                    Console.WriteLine("Индекс макс элемента: " + i);
                }
            }

        }
        static void Ex4()
        {
            Random rnd = new Random();
            Console.Write("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];


            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }

            Console.WriteLine("Исходный массив:");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("Удалить по индексу элемент: ");
            int DeleteIndex = Convert.ToInt32(Console.ReadLine());

            if (DeleteIndex >= 0 && DeleteIndex < n)
            {
                int[] arr2 = new int[n - 1];

                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (i != DeleteIndex)
                    {
                        arr2[j] = arr[i];
                        j++;
                    }
                }

                Console.WriteLine("Массив после удаления элемента:");
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Неверный индекс для удаления.");
            }
        }
        static void Ex5()
        {
            Random rnd = new Random();
            Console.Write("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Удалить элемент: ");
            int elements = Convert.ToInt32(Console.ReadLine());

            int counterElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == elements)
                {
                    counterElements++;
                }
            }

            int sizeArr2 = arr.Length - counterElements;
            int[] arr2 = new int[sizeArr2];
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != elements)
                {
                    arr2[counter] = arr[i];
                    counter++;
                }
            }
            if (counter == 0) { Console.WriteLine("Такога элемента нет в массиве!"); }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            
        }
        static void Ex6()
        {
            Random rnd = new Random();
            Console.Write("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int[] arr2= new int[n+1];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
            }
            
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Вставить элемент: ");
            int inputElements = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("В индекс: ");
            int inputIndex = Convert.ToInt32(Console.ReadLine());

            if (inputIndex < 0 || inputIndex > n)
            {
                Console.WriteLine("Неверный индекс для вставки.");
            }

            int counter = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (inputIndex == i)
                {
                    arr2[i] = inputElements;
                }
                else
                {
                    arr2[i] = arr[counter];
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив после вставки элемента:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();
        }
        static void Ex7()
        {
            Console.WriteLine("Размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Ввод элемента: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr2 = new int[n];
            int arr2Index = 0; 

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    arr2[arr2Index] = arr[i];
                    arr2Index++;
                }
            }

            for (int i = 0; i < arr2Index; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();

        }
        static void Ex8()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            // Приводим текст к нижнему регистру (для поиска без учета регистра)
            text = text.ToLower();

            if (text.Contains("one"))
            {
                Console.WriteLine("Слово 'one' найдено в тексте.");
            }
            else
            {
                Console.WriteLine("Слово 'one' не найдено в тексте.");
            }
        }
        static void Ex9()
        {
            Console.WriteLine("Введите текст:");
            string texts = Console.ReadLine();

            bool containsNonAlphanumeric = false;

            foreach (char c in texts)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    containsNonAlphanumeric = true;
                    break;
                }
            }

            if (containsNonAlphanumeric)
            {
                Console.WriteLine("Текст содержит символы, отличающиеся от букв и цифр");
            }
            else
            {
                Console.WriteLine("Текст не содержит символов, отличающихся от букв и цифр");
            }
        }
        static void Ex10()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            // Разбиваем текст на слова, используя пробелы в качестве разделителей
            string[] words = text.Split(' ');

            Console.WriteLine("Количество слов в тексте: " + words.Length);

            Console.WriteLine("Слова в столбик: ");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        static void Ex11()
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();

            char[] chars = word.ToCharArray();

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                {
                    chars[i] = '1';
                    chars[i + 1] = '1';
                }
            }

            string result = new string(chars);

            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
        static void Ex12()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char currentChar = chars[i];

                if (char.IsLower(currentChar))
                {
                    chars[i] = (char)(currentChar - 32); 
                }
                else if (char.IsUpper(currentChar))
                {
                    chars[i] = (char)(currentChar + 32);
                }
            }

            string convertedText = new string(chars);

            Console.WriteLine("Результат:");
            Console.WriteLine(convertedText);
        }
        static void Ex13()
        {
            Console.WriteLine("Введите целое число N (> 0):");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("Число должно быть больше 0.");
            }

            int reversedNumber = 0;

            while (N > 0)
            {
                int lastDigit = N % 10;
                reversedNumber = reversedNumber * 10 + lastDigit; 
                N = N / 10; 
            }

            Console.WriteLine(reversedNumber);
        }
        static void Ex14()
        {
            Console.WriteLine("Введите текст (для завершения введите точку):");

            int counter = 0;
            bool flag = false;

            while (!flag)
            {
                char inputChar = Console.ReadKey().KeyChar;

                if (inputChar == ' ')
                {
                    counter++;
                }
                else if (inputChar == '.')
                {
                    flag = true;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Количество введенных пробелов: " + counter);
        }
        static void Ex15()
        {
            int NumberOfTicket = 0;
            int partOfNum1, partOfNum2;
            int sum1 = 0, sum2 = 0;
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine("Введите номер билета: ");

                if (int.TryParse(Console.ReadLine(), out NumberOfTicket))
                {
                    if (NumberOfTicket >= 100000 && NumberOfTicket < 1000000)
                    {
                        flag = true;

                    }
                    else
                    {
                        Console.WriteLine("Введите 6-ти значное число!");
                    }
                }
                else
                {
                    Console.WriteLine("Введите номер билета числами!");
                }
            }
            partOfNum1 = NumberOfTicket / 1000;
            partOfNum2 = NumberOfTicket % 1000;

            while (partOfNum1 > 0)
            {
                int lastNumber1;
                int lastNumber2;

                lastNumber1 = partOfNum1 % 10;
                lastNumber2 = partOfNum2 % 10;

                sum1 += lastNumber1;
                sum2 += lastNumber2;

                partOfNum1 /= 10;
                partOfNum2 /= 10;

            }

            if (sum1 == sum2) { Console.WriteLine("Счастливое число!"); }
            else { Console.WriteLine("Не счастливое!"); }
        }
    }
}
