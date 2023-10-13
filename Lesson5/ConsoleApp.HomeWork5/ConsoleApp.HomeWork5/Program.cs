using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ClassLibrary.HomeWork5;

namespace ConsoleApp.HomeWork5
{
    internal class Program
    {
        static async System.Threading.Tasks.Task Main()
        {
            Console.WriteLine("Задание 1. Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. Программа должна завершиться без ошибок.");
            await Ex1();

            Console.WriteLine("Задание 2. Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.");
            Ex2();

            Console.WriteLine("Задание 3. Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.");
            Ex3();
        }
        static async Task Ex1()
        {
            Console.WriteLine("Обратиться к настоящему URL: \n 1) Выбрать 1. \n Обратиться не к настоящему URL\n 2) Выбрать 2.");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                try
                {
                    string Url = "https://my-json-server.typicode.com/typicode/demo/posts";

                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(Url);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonData = await response.Content.ReadAsStringAsync();
                            List<Practise5_DataJson> dataJSONList = JsonConvert.DeserializeObject<List<Practise5_DataJson>>(jsonData);

                            foreach (var dataJSON in dataJSONList)
                            {
                                Console.WriteLine("ID: " + dataJSON.Id);
                                Console.WriteLine("Title: " + dataJSON.Title);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Произошла ошибка при выполнении HTTP-запроса. Код состояния: " + response.StatusCode);
                        }
                    }
                }
                catch (System.Net.WebException ex)
                {
                    Console.WriteLine("Ошибка при обращении: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Другие ошибки: " + ex.Message);
                }
            }
            else if (choose == 2) 
            {
                try
                {
                    string Url = "https://my-json-server.typicode.kz/typicode/demo/posts";

                    using (HttpClient httpClient = new HttpClient())
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(Url);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonData = await response.Content.ReadAsStringAsync();
                            List<Practise5_DataJson> dataJSONList = JsonConvert.DeserializeObject<List<Practise5_DataJson>>(jsonData);

                            foreach (var dataJSON in dataJSONList)
                            {
                                Console.WriteLine("ID: " + dataJSON.Id);
                                Console.WriteLine("Title: " + dataJSON.Title);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Произошла ошибка при выполнении HTTP-запроса. Код состояния: " + response.StatusCode);
                        }
                    }
                }
                catch (System.Net.WebException ex)
                {
                    Console.WriteLine("Ошибка при обращении: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Другие ошибки: " + ex.Message);
                }
            }
        }   

        static void Ex2()
        {
            Random rnd = new Random();
            int size = 5;

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 10);
            }

            for (int i = 0; i < arr.Length + 1; i++) // Попробуем обратиться к элементу, выходящему за пределы массива
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Индекс выходит за пределы массива.");
                }
            }

            Console.WriteLine("Обработка массива завершена.");
        }
        static void Ex3()
        {
            try
            {
                CheckEngineCar okCar = new CheckEngineCar(true);
                okCar.StartEngine(); 
                okCar.Drive();

                CheckEngineCar brakeCar = new CheckEngineCar(false);
                brakeCar.StartEngine();
                brakeCar.Drive();
            }
            catch (EngineException ex)
            {
                Console.WriteLine("Обнаружено исключение: " + ex.Message);
            }
        }
    }
    
}
