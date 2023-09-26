using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryPractise4
{
    public struct Student
    {
        public string LastName;
        public string FirstName;
        public string SecondName;
        public int NumOfGroup;
        public int[] Grades;

        public string Initials()
        {
            if (!string.IsNullOrEmpty(SecondName))
            {
                return FirstName[0].ToString() + '.' + SecondName[0].ToString() + '.';
            }
            else
            {
                return FirstName[0].ToString() + '.';
            }
        }

        public double AvgGrades()
        {
            double sum = 0;
            if (Grades == null) {
                return 0.0;
            }

            for (int i = 0; i < Grades.Length; i++)
            {
                sum += Grades[i];
            }

            return sum / Grades.Length;
        }
    }

    public abstract class Animal
    {
        public int ID { get; set; }
        public string NameOfAnimal { get; set; }
        public double Weight { get; set; }

        public Animal(int id, string nameOfAnimal, double weight)
        {
            ID = id;
            NameOfAnimal = nameOfAnimal;
            Weight = weight;
        }

        public abstract void CalculateFood();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Идентификатор: {ID}, Имя: {NameOfAnimal}, Тип: {GetType().Name}");
        }
    }

    public class Hunter : Animal
    {
        public Hunter(int id, string nameOfHunter, double weight) : base(id, nameOfHunter, weight) { }

        public override void CalculateFood()
        {
            Console.WriteLine($"Требуется мясо для {NameOfAnimal} нуно {Weight / 20} кг.");
        }
    }

    public class Omnivore : Animal
    {
        public Omnivore(int id, string name, double weight) : base(id, name, weight) { }

        public override void CalculateFood()
        {
            Console.WriteLine($"Требуется разнообразная пища для {NameOfAnimal}  нуно {Weight / 20} кг.");
        }
    }

    public class Herbivore : Animal
    {
        public Herbivore(int id, string name, double weight) : base(id, name, weight) { }

        public override void CalculateFood()
        {
            Console.WriteLine($"Требуется растительная пища для {NameOfAnimal} нуно {Weight / 20} кг.");
        }
    }
    public class Book
    {
        public string Author { get; set; }
        public string NameOfBook { get; set; }
        public DateTime PublishedBook {get;set;}

        public Book(string author, string nameOfBook, DateTime publishedBook)
        {
            Author = author;
            NameOfBook = nameOfBook;
            PublishedBook = publishedBook;
        }
    }
    public class MyLib
    {
        List<Book> books = new List<Book>();
        public List<Book> Books
        {
            get { return books; }
        }
        public void AddBook(string author, string nameOfBook, DateTime publishedBook)
        {
            Book addBook = new Book(author, nameOfBook, publishedBook);
            books.Add(addBook);
        }
        public void RemoveBookByNameOfBook(string nameOfBook)
        {
            books.RemoveAll(book => book.NameOfBook == nameOfBook);
        }
        public void RemoveBookByAuthor(string author)
        {
            books.RemoveAll(book => book.Author == author);
        }
        public List<Book> FindBooksByAuthor(string author)
        {
            return books.Where(book => book.Author == author).ToList();
        }

        public List<Book> FindBooksByNameOfBook(string nameOfBook)
        {
            return books.Where(book => book.NameOfBook == nameOfBook).ToList();
        }
        public List<Book> FindBooksByPublishedBook(int year)
        {
            return books.Where(book => book.PublishedBook.Year == year).ToList();
        }
    }
    public class Trip
    {
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public bool IsCompleted { get; set; }
        public string CarStatus { get; set; }

        public Trip(string destination, DateTime departureTime)
        {
            Destination = destination;
            DepartureTime = departureTime;
            IsCompleted = false;
            CarStatus = "Готов";
        }

        public void MarkCompleted()
        {
            IsCompleted = true;
        }

        public void UpdateCarStatus(string status)
        {
            CarStatus = status;
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }

        public Car(string model, string licensePlate)
        {
            Model = model;
            LicensePlate = licensePlate;
        }
    }
    public class Driver
    {
        public string Name { get; set; }
        public Car AssignedCar { get; set; }
        public bool IsAvailable { get; set; }

        public Driver(string name)
        {
            Name = name;
            IsAvailable = true;
        }

        public void AssignCar(Car car)
        {
            AssignedCar = car;
        }

        public void MakeRepairRequest()
        {
            IsAvailable = false;
        }

        public void CompleteTrip(Trip trip)
        {
            trip.MarkCompleted();
        }


    }

    public class Dispatcher
    {
        public List<Driver> Drivers { get; set; }
        public List<Trip> Trips { get; set; }

        public Dispatcher()
        {
            Drivers = new List<Driver>();
            Trips = new List<Trip>();
        }

        public void AssignTrip(Trip trip, Driver driver)
        {
            if (driver.IsAvailable)
            {
                driver.AssignCar(new Car("Модель автомобиля", "Номерной знак"));
                driver.IsAvailable = false;
                Trips.Add(trip);
            }
            else
            {
                Console.WriteLine("Водитель уе назначен на другой рейс.");
            }
        }

        public void RemoveDriverFromWork(Driver driver)
        {
            driver.IsAvailable = false;
        }
        public Driver FindDriverByName(string name)
        {
            return Drivers.FirstOrDefault(driver => driver.Name == name);
        }
        public Trip FindTripByDestination(string destination)
        {
            return Trips.FirstOrDefault(trip => trip.Destination == destination);
        }
        public void AddDriver(Driver driver)
        {
            Drivers.Add(driver);
        }
    }
}
