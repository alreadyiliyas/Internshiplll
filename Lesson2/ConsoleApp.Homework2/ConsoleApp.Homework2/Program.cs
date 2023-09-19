using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.");
            Exercise1();

            Console.WriteLine("Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).");
            Exercise2();

            Console.WriteLine("Задание 3. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует Домашнее задание №1 Домашнее задание № все символы нижнего регистра в символы верхнего регистра и наоборот.");
            Exercise3();

            Console.WriteLine("Задание 4. Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:");
            Exercise4();

            Console.WriteLine("Задание 5. Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.");
            Exercise5();

            Console.WriteLine("Задание 6. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            Exercise6();

            Console.WriteLine("Задание 7. Вывести на экран числа 5, 10 и 21 одно под другим.");
            Exercise7();

            Console.WriteLine("Задание 16. вычисления значения функции y= 7x2-3x+6 при любом значении x;");
            Exercise8();

            Console.WriteLine("Задание 17. вычисления значения функции x= 12a2+7a-16 при любом значении а.");
            Exercise9();

            Console.WriteLine("Задание 18. Дана сторона квадрата. Найти его периметр.");
            Exercise10();

            Console.WriteLine("Задание 30. Даны два различных вещественных числа. Определить:\r\n\r\na. какое из них больше;\r\n\r\nb. какое из них меньше");
            Exercise11();

            Console.WriteLine("Задание 32. Дано натуральное число. Определить:\r\n\r\na. является ли оно четным;\r\n\r\nb. оканчивается ли оно цифрой 7");
            Exercise12();

            Console.WriteLine("Задание 34. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7) выводит на экран его название (понедельник, вторник, ..., воскресенье).");
            Exercise13();

            Console.WriteLine("Задание 35. Составить программу, которая в зависимости от порядкового номера дня месяца (1, 2, ..., 12) выводит на экран его название (январь, февраль, ..., декабрь).");
            Exercise14();

            Console.WriteLine("Задание 36. Составить программу, которая в зависимости от порядкового номера дня месяца (1, 2, ..., 12) выводит на экран время года, к которому относится этот месяц.");
            Exercise15();

            Console.WriteLine("Задание 40. Напечатать \"столбиком\":\r\n\r\na. все целые числа от 20 до 35;\r\n\r\nb. квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b больше или равно 10);\r\n\r\nc. третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a меньше или равно 50);\r\n\r\nd. все целые числа от a до b (значения a и b вводятся с клавиатуры; b больше или равно a).");
            Exercise16();

            Console.WriteLine("Задание 41. Напечатать таблицу соответствия между весом в фунтах и весом в килограммах для значений 1, 2, ..., 10 фунтов (1 фунт = 453 г).");
            Exercise17();

            Console.WriteLine("Задание 42. Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18 ... 9 х 9 = 81");
            Exercise18();

            Console.WriteLine("Задание 43. Дано натуральное число.\r\n\r\na. Верно ли, что сумма его цифр больше 10?\r\n\r\nb. Верно ли, что произведение его цифр меньше 50?\r\n\r\nc. Верно ли, что количество его цифр есть четное число?\r\n\r\nd. Верно ли, что это число четырехзначное? Составное условие и вложенный условный оператор не использовать.\r\n\r\ne. Верно ли, что его первая цифра не превышает 6?\r\n\r\nf. Верно ли, что оно начинается и заканчивается одной и той же цифрой?\r\n\r\ng. Определить, какая из его цифр больше: первая или последняя.");
            Exercise19();

            Console.WriteLine("Задание 39. Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20");
            Exercise20();
        }
        static void Exercise1()
        {
            int counterSpace = 0;
            char inputWord;

            Console.WriteLine("Введите текст, при точке остановится:");

            do
            {
                inputWord = Console.ReadKey().KeyChar;

                if (inputWord == ' ')
                {
                    counterSpace++;
                }
            }
            while (inputWord != '.');
            
            Console.WriteLine();
            Console.WriteLine("Кол-во пробелов: " + counterSpace);
        }
        static void Exercise2()
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
        static void Exercise3()
        {
            Console.WriteLine("Введите текст: ");

            string inputWord = Console.ReadLine();
            char[] chars = inputWord.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLower(chars[i]))
                {
                    chars[i] = (char)(chars[i] - 32);
                }
            }

            string result = new string(chars);
            Console.WriteLine(result);
        }
        static void Exercise4()
        {
            int A, B;
            Console.WriteLine("A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B: ");
            B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("A > B");
            }  
            for (; A <= B; A++) 
            {
                for (int j = 0; j < A; j++)
                {
                    Console.Write(A + " ");
                }
                Console.WriteLine();
            }
        }
        static void Exercise5()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Введите положительные числа!");
            }

            while(N > 0)
            {
                Console.Write(N%10);
                N /= 10;
            }
            Console.WriteLine();
        }
        static void Exercise6()
        {
            int number1 = 123;
            int number2 = 456;
            int number3 = 789;

            Console.WriteLine(number1 + " " + number2 + " " + number3);
        }
        static void Exercise7()
        {
            int five = 5;
            int ten = 10;
            int twentyOne = 21;

            Console.WriteLine(five);
            Console.WriteLine(ten);
            Console.WriteLine(twentyOne);
        }
        static void Exercise8()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            double y = 7 * x * x - 3 * x + 6;

            Console.WriteLine(y);
        }
        static void Exercise9()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            double x = 12 * a * a + 7 * a - 16;

            Console.WriteLine(x);   
        
        }
        static void Exercise10()
        {
            Console.WriteLine("Введите сторону квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пеример квадрата: " + 4 * a);
        }
        static void Exercise11()
        {
            Console.WriteLine("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y) { Console.WriteLine("Первое число больше"); }
            else if (x < y) { Console.WriteLine("Второе число больше"); }
            else { Console.WriteLine("Числа равны"); }
        }
        static void Exercise12()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number %2 == 0)
            { 
                Console.WriteLine("Число четное"); 
            }
            else if (number %2 == 1)
            {
                Console.WriteLine("Не четное число");
            }
            if (number % 10 == 7 ) 
            {
                Console.WriteLine("Оканчивается на цифру 7");
            }
        }
        static void Exercise13()
        {
            int number = 1;
            bool flag = false;
            
            while(!flag)
            {
                Console.WriteLine("Введите цифру от 1 до 7");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 1 || number > 7)
                    {
                        Console.WriteLine("Введите цифру от 1 до 7");
                    }
                    else { flag = true; }
                }
            }
            switch (number)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка: Введите число от 1 до 7.");
                    break;
            }
        }
        static void Exercise14()
        {
            int number = 1;
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine("Введите цифру от 1 до 12");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 1 || number > 12)
                    {
                        Console.WriteLine("Введите цифру от 1 до 12");
                    }
                    else { flag = true; }
                }
            }
            switch (number)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октрябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Ошибка: Введите число от 1 до 12");
                    break;
            }
        }
        static void Exercise15()
        {
            int number = 1;
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine("Введите цифру от 1 до 12");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 1 || number > 12)
                    {
                        Console.WriteLine("Введите цифру от 1 до 12");
                    }
                    else { flag = true; }
                }
            }
            switch (number)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Ошибка: Введите число от 1 до 12.");
                    break;
            }

        }
        static void Exercise16()
        {
            Console.WriteLine("все целые числа от 20 до 35;");
            for (int i = 20; i < 36; i++) {
                Console.WriteLine(i);
            }

            Console.WriteLine("квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b больше или равно 10);");
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b <= 10)
            {
                Console.WriteLine("b < 10");
            }
            for(int i = 10; i < b; i++)
            {
                Console.WriteLine(i*i);
            }

            Console.WriteLine("третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a меньше или равно 50);");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 50)
            {
                Console.WriteLine("A > 50");
            }

            for(; a < 50; a++)
            {
                Console.WriteLine(a * a * a);
            }

            Console.WriteLine("все целые числа от a до b (значения a и b вводятся с клавиатуры; b больше или равно a).");
            Console.Write("a: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.Write("b: ");
            int l = Convert.ToInt32(Console.ReadLine());

            if (z > l)
            {
                Console.WriteLine("a > b");
            }

            for (; z < l; z++)
            {
                Console.WriteLine(z);
            }
        }
        static void Exercise17()
        {
            int funt = 453;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * funt);
            }
        }
        static void Exercise18()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i*9);
            }
        }
        static void Exercise19()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
            int product = 1;
            int count = 0;
            int firstDigit = number % 10;
            int lastDigit = number;

            while (lastDigit >= 10)
            {
                lastDigit /= 10;
            }

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                count++;
                number /= 10;
            }

            bool isSumGreaterThan10 = sum > 10;
            bool isProductLessThan50 = product < 50;
            bool isCountEven = count % 2 == 0;
            bool isFourDigit = count == 4;
            bool isFirstDigitNotGreaterThan6 = firstDigit <= 6;
            bool isStartAndEndSame = firstDigit == lastDigit;
            bool isFirstDigitGreater = firstDigit > lastDigit;

            Console.WriteLine("Сумма цифр больше 10: " + isSumGreaterThan10);
            Console.WriteLine("Произведение цифр меньше 50: " + isProductLessThan50);
            Console.WriteLine("Количество цифр четное: " + isCountEven);
            Console.WriteLine("Число четырехзначное: " + isFourDigit);
            Console.WriteLine("Первая цифра не превышает 6: " + isFirstDigitNotGreaterThan6);
            Console.WriteLine("Начинается и заканчивается одной цифрой: " + isStartAndEndSame);

            if (isFirstDigitGreater)
            {
                Console.WriteLine("Первая цифра больше последней.");
            }
            else
            {
                Console.WriteLine("Последняя цифра больше первой или они равны.");
            }
        }
        static void Exercise20()
        {
            int number = 20;
            for(int i = 0; i < 10; i++)
            {
                Console.Write(number);
            }
        }
    }
}
