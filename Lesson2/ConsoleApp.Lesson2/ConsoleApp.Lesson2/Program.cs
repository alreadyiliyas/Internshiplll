using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            Ex1();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 2: ");
            Ex2();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 3. Введите число: ");
            Ex3();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 4: ");
            Ex4();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 5. Введите 2-х значное число: ");
            Ex5();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 6: ");
            Ex6();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 7: ");
            Ex7();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 8: ");
            Ex8();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 10: ");
            Ex10();
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 11. Введите х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Ex11(x);
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 12. Введите радиус: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Ex12(R);
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 19. Введите х: ");
            int x19 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задание 19. Введите y: ");
            int y19 = Convert.ToInt32(Console.ReadLine());
            Ex19(x19, y19);
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 22. Введите х: ");
            int x22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задание 22. Введите y: ");
            int y22 =  Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Ex22(x22, y22));
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 23. Введите H: ");
            int h23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задание 23. Введите M: ");
            int m23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задание 23. Введите S: ");
            int s23 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Ex23(h23, m23, s23));
            Console.WriteLine("__________________");

            Console.WriteLine("Задание 24. Введите m:");
            int m24 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задание 24. Введите d:");
            int d24 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ex24(m24, d24));
            Console.WriteLine("_________________");

            Console.WriteLine("Задание 25. Введите m:");
            int m25 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задание 25. Введите d:");
            int d25 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ex25(m25, d25));
            Console.WriteLine("_________________");

            Console.WriteLine("Задание 26. Введите m1:");
            int m26 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задание 26. Введите m2:");
            int d26 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задание 26. Введите m3:");
            int a26 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ex26(m26, d26, a26));
            Console.WriteLine("_________________");

            Console.WriteLine("Задание 27. Введите число: ");
            int number27 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ex27(number27));
            Console.WriteLine("_________________");

            Console.WriteLine("Задание 28. Введите число: ");
            int number28 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ex28(number28));
            Console.WriteLine("_________________");

            Console.WriteLine("Задание 30. Введите число от m: ");
            int m30 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задание 30. Введите число до n: ");
            int n30 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Ex30(m30, n30));
            Console.WriteLine("_________________");


        }
        static void Ex1()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            Console.WriteLine(x + "  " + y + "  " + z);
        }
        static void Ex2()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
        static void Ex3()
        {
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x / 100);
        }
        static void Ex4()
        {
            var nowDate = DateTime.Now;
            int weeks = -234;
            var newDate = nowDate.AddDays(weeks);
            weeks = weeks / -7;
            Console.WriteLine(newDate + " Прошло недель: " + weeks);
        }
        static void Ex5()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 10 && x > 100)
            {
                Console.WriteLine("Число не 2-х значное");
            }
            Console.WriteLine(x / 10);
            int count1 = 0;
            if (x % 10 == 1)
            {
                count1++;
            }
            if (x / 10 == 1)
            {
                count1++;
            }
            Console.WriteLine("Число 1 в 2-х числах: " + count1);

            //Сумма цифр числа
            int sum = (x % 10) + (x / 10);
            Console.WriteLine("Сумма цифр" + sum);

            //Умножение цифр числа
            int multi = (x % 10) * (x / 10);
            Console.WriteLine("Умножение цифр числа: " + multi);
        }
        static void Ex6()
        {
            bool A, B, C;
            A = true;
            B = false;
            C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
        }
        static void Ex7()
        {
            int R, a;
            double SCirlce, SSquare;

            Console.Write("Введите радиус: ");
            R = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сторону квадрата: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            if (R <= 0 && a <= 0) 
            {
                Console.WriteLine("Площадь не может быть отрицательным!");
            }
            
            //Площадь Круга
            SCirlce = 3.14 * R * R;
            //Площадь Квадрата
            SSquare = a * a;

            if (SCirlce > SSquare)
            {
                Console.WriteLine("Плоащдь круга больше");
            }
            else if (SCirlce < SSquare)
            {
                Console.WriteLine("Плоащдь квадрата больше");
            }
        }
        static void Ex8()
        {
            Console.WriteLine("Введите материал 1: ");
            string firstMaterial = Console.ReadLine();


            Console.WriteLine("Введите материал 2: ");
            string secondMaterial = Console.ReadLine();


            Console.WriteLine("Масса 1 материала");
            int massMaterial1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Масса 2 материала");
            int massMaterial2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Объем 1 материала: ");
            int vMaterial1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Объем 2 материала: ");
            int vMaterial2 = Convert.ToInt32(Console.ReadLine());

            int pMaterial1 = massMaterial1 * vMaterial1;
            int pMaterial2 = massMaterial2 * vMaterial2;

            if (pMaterial1 > pMaterial2)
            {
                Console.WriteLine("Плотность " + firstMaterial + " больше чем" + secondMaterial);
            }

            else if (pMaterial2 > pMaterial1)
            {
                Console.WriteLine("Плотность " + secondMaterial + " больше чем" + firstMaterial);
            }
        }
        static void Ex10()
        {
            //Все целые числа от 20-35

            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);
            }

            //квадраты всех целых чисел
            //от 10 до b (значение b вводится с клавиатуры; b > 10);
            Console.WriteLine("Вывести число от 10 до b, Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            // третьи степени всех целых
            // чисел от a до 50 (значение a вводится с клавиатуры; a < 50); 

            Console.WriteLine("от a до 50, Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            for (; a < 50; a++)
            {
                Console.WriteLine(a * a * a);
            }
        }
        static void Ex11(int x)
        {
            int y = 7 * x * x - 3 * x + 4;
            Console.WriteLine("y: " + y);
        }
        static void Ex12(int r)
        {
            double pi, l, S;
            pi = 3.14;
            l = 2 * pi * r;
            S = pi * r * r;

            Console.WriteLine("l: " + l);
            Console.WriteLine(": " + S);

        }
        static void Ex19(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"{a} {b}");
        }
        static int Ex22(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (y == 0)
            {
                return 12 / x;
            }
            else if (x == 0)
            {
                return 12 / y;
            }
            else
            {
                return 144 / (x * y);
            }
        }
        static int Ex23(int h, int m, int s)
        {
            int sum = h * 60 + m * 60 + s;
            return sum;
        }
        static int Ex24(int m, int d)
        {
            return m * 30 + d;
        }
        static int Ex25(int m, int d)
        {
            int sumDay = 0;
            for (int i = 1; i < m; i++)
            {
                if (i == 2)
                {
                    sumDay += 28;
                }
                else if (i % 2 == 0 && i != 2)
                {
                    sumDay += 30;
                }
                else if (i % 2 == 1)
                {
                    sumDay += 31;
                }
            }
            return sumDay + d;
        }
        static int Ex26(int m1, int m2, int m3)
        {
            if (m1 < 1 || m1 > 999 || m2 < 1 || m2 > 999 || m3 < 1 || m3 > 999)
            {
                return 0;
            }
            if (m1 <= m2 && m1 <= m3)
            {
                return m1;
            }
            else if (m2 <= m1 && m2 <= m3)
            {
                return m2;
            }
            else
            {
                return m3;
            }
        }
        static bool Ex27(int n)
        {
            if (n % 2 == 0) { return true; }
            return false;
        }
        static int Ex28(int n)
        {
            int[] arr = new int[3];
            int i = 2; // Индекс начинается с 2, так как у вас массив размером 3, и индексы от 0 до 2
            if (n < 100 & n > 1000)
            {
                return 0;
            }
            while (n > 0 && i >= 0)
            {
                arr[i] = n % 10;
                n /= 10; // Деление на 10 для перехода к следующей цифре
                i--;
            }
            return arr.Min();
        }
        static int Ex30(int m, int n)
        {
            int sum = 0;
            
            if (m > n)
            {
                return -1;
            }

            for (; m <= n; m++)
            {
                if (m%2 != 0)
                {
                    sum += m;
                } 
            }
            
            return sum;
        }

    }
}
