using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPractise4;

namespace ConsoleApp.Practise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Создайте структуру с именем student, содеращую поля: фамилия и инициалы, номер группы, успеваемость (массив из пяти элементов). Создать массив из десяти элементов такого типа, упорядочить записи по возрастанию среднего балла. Добавить возмоность вывода фамилий и номеров групп студентов, имеющих оценки, равные только 4 или 5.");
            Console.WriteLine();
            //Ex1();

            Console.WriteLine("Задание 2. Построить три класса (базовый и 3 потомка), описывающих некоторых хищных ивотных (один из потомков), всеядных(второй потомок) и травоядных (третий потомок). Описать в базовом классе абстрактный метод для расчета количества и типа пищи, необходимого для пропитания ивотного в зоопарке.");
            //Ex2();

            Console.WriteLine("Задание 3. Описать класс «домашняя библиотека». Предусмотреть возмоность работы с произвольным числом книг, поиска книги по какому-либо признаку (например, по автору или по году издания), добавления книг в библиотеку, удаления книг из нее, сортировки книг по разным полям.");
            Console.WriteLine();
            //Ex3();

            Console.WriteLine("Задание 4. Задача на взаимодействие меду классами. Разработать систему «Автобаза». Диспетчер распределяет заявки на Рейсы меду Водителями и назначает для этого Автомобиль. Водитель моет сделать заявку на ремонт. Диспетчер моет отстранить Водителя от работы. Водитель делает отметку о выполнении Рейса и состоянии Автомобиля.");
            Console.WriteLine();
            Ex4();
        }
        public static void Ex1()
        {
            Student[] students = new Student[10]
            {
                new Student { LastName = "Укенов", FirstName = "Ильяс", SecondName = "Айдынулы", NumOfGroup = 1, Grades = new int[] { 5, 5, 5, 5, 5 } },
                new Student { LastName = "Шопалов", FirstName = "Ислам", NumOfGroup = 2, Grades = new int[] { 4, 4, 3, 4, 5 } },
                new Student { LastName = "Адильханов", FirstName = "Олас", NumOfGroup = 3, Grades = new int[] { 5, 5, 5, 5, 5 } },
                new Student { LastName = "Исаев", FirstName = "Эльхан", NumOfGroup = 2, Grades = new int[] { 4, 5, 4, 4, 3 } },
                new Student { LastName = "умагалиев", FirstName = "Амир", NumOfGroup = 1, SecondName = "Болатович", Grades = new int[] { 5, 5, 5, 5, 5 } },
                new Student { LastName = "Калибеков", FirstName = "Санар", NumOfGroup = 2, Grades = new int[] { 4, 5, 4, 4, 3 } },
                new Student { LastName = "Сабитов", FirstName = "Алиха", NumOfGroup = 1, Grades = new int[] { 5, 5, 5, 5, 5 } },
                new Student { LastName = "Хан", FirstName = "Вячеслав", NumOfGroup = 3, Grades = new int[] { 3, 3, 3, 3, 3 } },
                new Student { LastName = "Идрисов", FirstName = "Аймурат", NumOfGroup = 1, Grades = new int[] { 3, 4, 3, 3, 4 } },
                new Student { LastName = "Омирзак", FirstName = "Динмухаммед", NumOfGroup = 3, Grades = new int[] { 5, 5, 5, 5, 5 } }
            };

            var sortedStudents = students.OrderByDescending(student => student.AvgGrades());


            foreach (var stud in sortedStudents)
            {
                Console.WriteLine($"Имя: {stud.LastName} {stud.Initials()}, группа: {stud.NumOfGroup}, средняя оценка: {stud.AvgGrades()}");
            }

            Console.WriteLine("Вывести студентов у которых все 4 или 5?: ");
            Console.WriteLine("Для вывода студентов у которых все 4, написать 4");
            Console.WriteLine("Для вывода студентов у которых все 5, написать 5");
            int Choose = Convert.ToInt32(Console.ReadLine());

            if (Choose == 4)
            {
                foreach (var stud in students)
                {
                    if (stud.AvgGrades() == 4.0)
                    {
                        Console.WriteLine($"Имя: {stud.LastName} {stud.Initials()}, группа: {stud.NumOfGroup}, средняя оценка: {stud.AvgGrades()}");
                    }
                }
            }

            else if (Choose == 5)
            {
                foreach (var stud in students)
                {
                    if (stud.AvgGrades() == 5.0)
                    {
                        Console.WriteLine($"Имя: {stud.LastName} {stud.Initials()}, группа: {stud.NumOfGroup}, средняя оценка: {stud.AvgGrades()}");
                    }
                }
            }
        }
        public static void Ex2()
        {
            Hunter[] hunter = new Hunter[3]
            {
                new Hunter( 1, "Тигр", 350.0),
                new Hunter( 2, "Лев", 250.0),
                new Hunter( 3, "Леопард", 230.0)
            };
            Omnivore[] omnivore = new Omnivore[3]
            {
                new Omnivore(4, "Медведь", 500.0),
                new Omnivore(5, "Крыса", 8.0),
                new Omnivore(6, "аба", 3.0)
            };
            Herbivore[] herbivore = new Herbivore[3]
            {
                new Herbivore(7,"Панда", 80.0),
                new Herbivore(8,"Лама", 210.0),
                new Herbivore(9,"Барашек", 80.0)
            };

            List<Animal> animals = new List<Animal>();
            animals.AddRange(hunter);
            animals.AddRange(omnivore);
            animals.AddRange(herbivore);

            var sortedAnimals = animals.OrderByDescending(a => a.NameOfAnimal)
                                       .ThenBy(a => a.NameOfAnimal)
                                       .ToList();
            Console.WriteLine("\r\n\r\na. Упорядочить всю последовательность ивотных по убыванию количества пищи. При совпадении значений – упорядочивать данные по алфавиту по имени. Вывести идентификатор ивотного, имя, тип и количество потребляемой пищи для всех элементов списка.");
            foreach (var animal in sortedAnimals)
            {
                Console.WriteLine($"Идентификатор: {animal.ID}, Имя: {animal.NameOfAnimal}, Тип: {animal.GetType().Name}");
                Console.WriteLine();
                animal.CalculateFood();
            }
            Console.WriteLine();

            Console.WriteLine("Вывести первые 5 имен ивотных из полученного в пункте а) списка.");
            var first5Names = sortedAnimals.Take(5).Select(a => a.NameOfAnimal);

            Console.WriteLine("Первые 5 имен ивотных:");
            foreach (var name in first5Names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var last3Ids = sortedAnimals.Skip(sortedAnimals.Count - 3).Select(a => a.ID);

            Console.WriteLine("Последние 3 идентификатора ивотных:");
            foreach (var id in last3Ids)
            {
                Console.WriteLine(id);
            }
        }
        public static void Ex3()
        {
            MyLib myLib = new MyLib();

            DateTime date1 = new DateTime(1966, 7, 20);
            DateTime date2 = new DateTime(2008, 5, 25);
            DateTime date3 = new DateTime(1925, 4, 4);

            myLib.AddBook("Михаил Булгаков", "Мастер и Маргарита", date1);
            myLib.AddBook("Рэй Брэдбери", "451° по Фаренгейту", date2);
            myLib.AddBook("Михаил Булгаков", "Собачье сердце", date3);

            Console.WriteLine("Все книги: ");
            foreach(var book in myLib.Books)
            {
                Console.WriteLine($"Автор: {book.Author}, Название: {book.NameOfBook}, Дата публикации: {book.PublishedBook}");
            }

            Console.WriteLine("Для взаимодействия с библиотекой напишите 0: ");
            int Choose = Convert.ToInt32(Console.ReadLine());

            while (Choose != 7)
            {
                Console.WriteLine("Добавить книгу, напишите 1:");
                Console.WriteLine("Удалить книгу по названию, напишите 2:");
                Console.WriteLine("Удалить книгу по автору, напишите 3:");
                Console.WriteLine("Найти книгу по автору, напишите 4:");
                Console.WriteLine("Найти книгу по названию, напишите 5:");
                Console.WriteLine("Найти книгу по дате издательства, напишите 6:");
                Console.WriteLine("Напишите 7 чтобы остановить:");
                Choose = Convert.ToInt32(Console.ReadLine());

                if (Choose == 1)
                {
                    Console.Write("Напишите автора: ");
                    string Author = Console.ReadLine();
                    Console.Write("Напишите название книги: ");
                    string NameOfBook = Console.ReadLine();
                    Console.Write("Напишите год издания: ");
                    DateTime PublishedBook = Convert.ToDateTime(Console.ReadLine());

                    myLib.AddBook(Author, NameOfBook, PublishedBook);
                }
                else if (Choose == 2)
                {
                    Console.WriteLine("Напишите название книги, которую хотите удалить: ");
                    string nameOfBook = Console.ReadLine();

                    myLib.RemoveBookByNameOfBook(nameOfBook);
                }
                else if (Choose == 3)
                {
                    Console.WriteLine("Напишите автора, которого хотите удалить: ");
                    string author = Console.ReadLine(); 

                    myLib.RemoveBookByAuthor(author);
                }
                else if (Choose == 4)
                {
                    Console.WriteLine("Напишите автора по которому хотите найти книгу");
                    string author = Console.ReadLine(); 

                    List<Book> foundBooks = myLib.FindBooksByAuthor(author);

                    Console.WriteLine("Найденные книги: ");
                    foreach (var book in foundBooks)
                    {
                        Console.WriteLine($"Автор: {book.Author}, Название: {book.NameOfBook}, Дата публикации: {book.PublishedBook}");
                    }
                }
                else if (Choose == 5)
                {
                    Console.WriteLine("Напишите название по которому хотите найти книгу");
                    string nameOfBook = Console.ReadLine();

                    List<Book> foundBooks = myLib.FindBooksByAuthor(nameOfBook);

                    Console.WriteLine("Найденные книги: ");
                    foreach (var book in foundBooks)
                    {
                        Console.WriteLine($"Автор: {book.Author}, Название: {book.NameOfBook}, Дата публикации: {book.PublishedBook}");
                    }
                }
                else if (Choose == 6)
                {
                    Console.WriteLine("Напишите год, чтобы найти книгу");
                    int year = Convert.ToInt32(Console.ReadLine());

                    List<Book> foundBooks = myLib.FindBooksByPublishedBook(year);

                    Console.WriteLine("Найденные книги: ");
                    foreach (var book in foundBooks)
                    {
                        Console.WriteLine($"Автор: {book.Author}, Название: {book.NameOfBook}, Дата публикации: {book.PublishedBook}");
                    }
                }
            }
            Console.WriteLine("Обновленная библиотека: ");
            foreach (var book in myLib.Books)
            {
                Console.WriteLine($"Автор: {book.Author}, Название: {book.NameOfBook}, Дата публикации: {book.PublishedBook}");
            }
        }
        public static void Ex4()
        {
            Dispatcher dispatcher = new Dispatcher();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Создать водителя");
                Console.WriteLine("2. Назначить поездку водителю");
                Console.WriteLine("3. Завершить поездку водителя");
                Console.WriteLine("4. Завершить рейс");
                Console.WriteLine("5. Установить статус машины");
                Console.WriteLine("6. Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateDriver(dispatcher);
                        break;
                    case "2":
                        AssignTripToDriver(dispatcher);
                        break;
                    case "3":
                        CompleteTripForDriver(dispatcher);
                        break;
                    case "4":
                        CompleteTrip(dispatcher);
                        break;
                    case "5":
                        UpdateCarStatus(dispatcher);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
        public static void CreateDriver(Dispatcher dispatcher)
        {
            Console.WriteLine("Введите имя водителя:");
            string driverName = Console.ReadLine();

            Driver driver = new Driver(driverName);

            dispatcher.AddDriver(driver);

            // Вывести информацию о созданном водителе
            Console.WriteLine($"Создан водитель: {driver.Name}, Доступен: {driver.IsAvailable}");
        }

        public static void AssignTripToDriver(Dispatcher dispatcher)
        {
            Console.WriteLine("Введите имя водителя:");
            string driverName = Console.ReadLine();

            Driver driver = dispatcher.FindDriverByName(driverName);

            if (driver != null)
            {
                Console.WriteLine("Введите название направления:");
                string destination = Console.ReadLine();
                Trip trip = new Trip(destination, DateTime.Now);

                dispatcher.AssignTrip(trip, driver);

                // Вывести информацию о назначенной поездке
                Console.WriteLine($"Поездка назначена водителю {driver.Name}: {trip.Destination}, Дата отправления: {trip.DepartureTime}");
            }
            else
            {
                Console.WriteLine("Водитель не найден.");
            }
        }

        public static void CompleteTripForDriver(Dispatcher dispatcher)
        {
            Console.WriteLine("Введите имя водителя:");
            string driverName = Console.ReadLine();

            Driver driver = dispatcher.FindDriverByName(driverName);

            if (driver != null)
            {
                Console.WriteLine("Введите название направления рейса:");
                string destination = Console.ReadLine();
                Trip trip = dispatcher.FindTripByDestination(destination);

                if (trip != null)
                {
                    driver.CompleteTrip(trip);

                    // Вывести информацию о завершенной поездке
                    Console.WriteLine($"Поездка завершена водителем {driver.Name}: {trip.Destination}");
                }
                else
                {
                    Console.WriteLine("Рейс не найден.");
                }
            }
            else
            {
                Console.WriteLine("Водитель не найден.");
            }
        }

        public static void CompleteTrip(Dispatcher dispatcher)
        {
            Console.WriteLine("Введите название направления рейса:");
            string destination = Console.ReadLine();
            Trip trip = dispatcher.FindTripByDestination(destination);

            if (trip != null)
            {
                trip.MarkCompleted();

                // Вывести информацию о завершенном рейсе
                Console.WriteLine($"Рейс завершен: {trip.Destination}");
            }
            else
            {
                Console.WriteLine("Рейс не найден.");
            }
        }

        public static void UpdateCarStatus(Dispatcher dispatcher)
        {
            Console.WriteLine("Введите название направления рейса:");
            string destination = Console.ReadLine();
            Trip trip = dispatcher.FindTripByDestination(destination);

            if (trip != null)
            {
                Console.WriteLine("Введите статус машины:");
                string status = Console.ReadLine();
                trip.UpdateCarStatus(status);

                // Вывести информацию об обновлении статуса машины
                Console.WriteLine($"Статус машины обновлен для рейса {trip.Destination}: {trip.CarStatus}");
            }
            else
            {
                Console.WriteLine("Рейс не найден.");
            }
        }
    }
}
