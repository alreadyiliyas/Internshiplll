using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Создать индексатор, для одномерного массива, который при установке значения будет возводить в квадрат передаваемое значение переменной и устанавливать его для указанного индекса. При получении элемента массива по индексу будет возвращаться его текущее значение.");
            Ex1();
            Console.WriteLine("Задание 2. 2.\tНаписать программу, рассчитывающую сумму коммунальных платежей: есть базовые тарифы на отопление (на 1 м2 площади), на воду (на 1 чел), на газ (на 1 чел), на текущий ремонт (на 1 м2 площади). Задается метраж помещения, количество проживающих людей, сезон (осенью и зимой отопление дороже), наличие льгот (ветеран труда– 30 % от его части; ветеран войны- 50% от его части). Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка, Итого. Посчитать итоговую сумму.");
            Ex2();
        }
        public static void Ex1()
        {
            ExampleArray exampleArray = new ExampleArray();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                exampleArray[i] = rnd.Next(0, 100);
            }

            Console.WriteLine("Заполненный массив: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(exampleArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Обратиться по индексу: ");
            int chooseIndex = Convert.ToInt32(Console.ReadLine());
            int outputValue = exampleArray[chooseIndex - 1];

            Console.WriteLine(outputValue);

            exampleArray[chooseIndex - 1] = outputValue * outputValue;

            Console.WriteLine("Возведение в квадрат: ");
            Console.Write(exampleArray[chooseIndex - 1]);

            Console.WriteLine();
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(exampleArray[i] + " ");
            }
        }
        public static void Ex2()
        {
            Console.WriteLine("Введите квадратуру помещения: ");
            double inputSpace = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Количество чел-век в помещении: ");
            int countPeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Есть ли проживающие люди имеющие льготы (ветераны труда, ветераны войны) ?");
            Console.WriteLine("[Да: 1, Нет: 2]");

            int inputPrivileges = Console.ReadKey().KeyChar - '0';
            int countPeopleWithPrivileges;
            if (inputPrivileges == 1)
            {
                Console.WriteLine("Напишите кол-во людей имеющие льготы: ");
                countPeopleWithPrivileges = Convert.ToInt32(Console.ReadLine());
            }
            else 
            { 
                countPeopleWithPrivileges = 0; 
            }
            ServiceEx2(inputSpace, countPeople, inputPrivileges);

        }
        public static void ServiceEx2(double inputSpace, int countPeople, int countPeopleWithPrivileges)
        {
            ExirciseClass2 exerciseClass2 = new ExirciseClass2();
            exerciseClass2["Space"] = inputSpace;
            exerciseClass2["Maintenance"] = inputSpace;
            exerciseClass2["PriceGas"] = 55.1;
            exerciseClass2["PriceLiterWater"] = 10.8;

            double monthlyRate = (exerciseClass2["Maintenance"] + exerciseClass2["PriceGas"] + exerciseClass2["PriceLiterWater"] * exerciseClass2["Space"]) * countPeople;

            // Если есть люди с льготами
            if (countPeopleWithPrivileges > 0)
            {
                Console.WriteLine("Какие льготы есть у проживающих?");
                Console.WriteLine("Ветераны труда (30% скидка): 1");
                Console.WriteLine("Ветераны войны (50% скидка): 2");
                int privilegeType = Convert.ToInt32(Console.ReadLine());

                if (privilegeType == 1)
                {
                    double discount = 0.3; 
                    double discountedRate = monthlyRate * (1 - discount);
                    Console.WriteLine("Тариф за 1 месяц (с учетом скидки для ветеранов труда): " + discountedRate);
                }
                else if (privilegeType == 2)
                {
                    double discount = 0.5;
                    double discountedRate = monthlyRate * (1 - discount);
                    Console.WriteLine("Тариф за 1 месяц (с учетом скидки для ветеранов войны): " + discountedRate);
                }
                else
                {
                    Console.WriteLine("Неверный тип льготы.");
                }
            }
            Console.WriteLine("Тариф за 1 месяц: " + monthlyRate);
            
            double annualRate = monthlyRate * 12;
            if (exerciseClass2.IsAutumnOrWinter())
            {
                double gasPriceIncrease = 0.25; // Увеличение цены на газ на 25% осенью и зимой
                annualRate += (exerciseClass2["PriceGas"] * exerciseClass2["Space"] * countPeople) * gasPriceIncrease;
                Console.WriteLine("Тариф за 1 год (осень/зима): " + annualRate);
            }
            else
            {
                Console.WriteLine("Тариф за 1 год: " + annualRate);
            }

        }
    }
    public class ExampleArray
    {
        private int[] arr = new int[10];

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }
    public class ExirciseClass2
    {
        public double Space { get; set; }
        public double PriceLiterWater { get; set; }
        public double PriceGas { get; set; }
        public double Maintenance { get; set; }

        public bool IsAutumnOrWinter()
        {
            int currentMonth = DateTime.Now.Month;
            return currentMonth >= 10 || currentMonth <= 3;
        }
        public double this[string parameter]
        {
            get
            {
                switch (parameter)
                {
                    case "Space":
                        return Space;
                    case "PriceLiterWater":
                        return PriceLiterWater;
                    case "PriceGas":
                        return PriceGas;
                    case "Maintenance":
                        return Maintenance;
                    default:
                        return 1;
                }
            }
            set
            {
                switch (parameter)
                {
                    case "Space":
                        Space = value;
                        break;
                    case "PriceLiterWater":
                        PriceLiterWater = value;
                        break;
                    case "PriceGas":
                        PriceGas = value;
                        break;
                    case "Maintenance":
                        Maintenance = value;
                        break;
                }
            }
        }
    }
}
