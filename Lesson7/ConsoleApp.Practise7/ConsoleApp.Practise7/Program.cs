using ClassLibrary.Practise7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Создать класс с несколькими свойствами. Реализовать перегрузку операторов ==, != и Equals.");
            Ex1();
            Console.WriteLine("Задание 2. Дан класс содержащий внутри себя массив. Реализовать перегрузку операторов < , > так, чтобы если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.");
            Ex2();
            Console.WriteLine("Задание 3. Задание будет базироваться на примере в этом уроке. Необходимо реализовать второй вариант сложения денег – чтобы можно было суммировать деньги в разных валютах. Для этого создайте отдельный класс, который будет предоставлять механизм конвертации денег по заданному курсу. Кроме этого, перегрузите для класса Money оператор сравнения «==» (при перегрузке данного оператора, обязательной является и перегрузка противоположного ему оператора «!=»).");
            Ex3();
            Console.WriteLine("Задание 4. Класс – одномерный массив. Дополнительно перегрузить следующие операции: * – умножение массивов; [] – доступ по индексу, int() – размер массива; == – проверка на равенство; <= – сравнение");
            Ex4();
        }
        static void Ex1()
        {
            Person person1 = new Person("Iliyas", "Ukenov", 30);
            Person person2 = new Person("NotIliyas", "NotUkenov", 25);
            Person person3 = new Person("John", "Doe", 30);

            // Сравнение с использованием оператора ==
            bool areEqual = (person1 == person2);
            Console.WriteLine("person1 == person2: " + areEqual);

            areEqual = (person1 == person3);
            Console.WriteLine("person1 == person3: " + areEqual);

            // Сравнение с использованием оператора !=
            bool areNotEqual = (person1 != person2);
            Console.WriteLine("person1 != person2: " + areNotEqual);

            areNotEqual = (person1 != person3);
            Console.WriteLine("person1 != person3: " + areNotEqual);

            // Сравнение с использованием метода Equals
            bool equalsMethod = person1.Equals(person2);
            Console.WriteLine("person1.Equals(person2): " + equalsMethod);

            equalsMethod = person1.Equals(person3);
            Console.WriteLine("person1.Equals(person3): " + equalsMethod);
        }
        static void Ex2()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] array3 = { 7, 8, 9 };


            for (int i = 0; i < 3; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();


            ArrayContainer container1 = new ArrayContainer(array1);
            ArrayContainer container2 = new ArrayContainer(array2);
            ArrayContainer container3 = new ArrayContainer(array3);

            Console.WriteLine("container1 < container2: " + (container1 < container2)); // true
            Console.WriteLine("container2 > container3: " + (container2 > container3)); // false
        }
        static void Ex3()
        {
            Money money1 = new Money(100, "USD");
            Money money2 = new Money(200, "USD");
            Money money3 = new Money(250, "EUR");
            Money money4 = new Money(70, "EUR");

            Console.WriteLine("Money1 + Money2: " + (money1 + money2).Amount); // 300
            Console.WriteLine("Money1 - Money2: " + (money1 - money2).Amount); // -100

            Console.WriteLine("Money1 == Money2: " + (money1 == money2)); // true
            Console.WriteLine("Money1 == Money3: " + (money1 == money3)); // false

            Console.WriteLine("Money3 != Money4: " + (money3 != money4)); // true
        }
        static void Ex4()
        {
            MyArray array1 = new MyArray(1, 2, 3);
            MyArray array2 = new MyArray(4, 5, 6);

            Console.WriteLine("Array 1:");
            PrintArray(array1);

            Console.WriteLine("Array 2:");
            PrintArray(array2);

            MyArray multiplicationResult = array1 * array2;

            Console.WriteLine("Result of multiplication:");
            PrintArray(multiplicationResult);

            bool isEqual = array1 == array2;
            Console.WriteLine($"Arrays are equal: {isEqual}");

            bool isLessThanOrEqual = array1 <= array2;
            Console.WriteLine($"Array 1 is less than or equal to Array 2: {isLessThanOrEqual}");
        }

        static void PrintArray(MyArray array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
