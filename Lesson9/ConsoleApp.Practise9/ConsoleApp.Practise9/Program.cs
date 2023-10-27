using ClassLibrary.Practise9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Flash storageFlash = new Flash("Hyper X", "WS-1000", 1024, 200);
            HDD storageHDD = new HDD("Western Digital", "500", 500, 480, 3);
            DVD storageDVD = new DVD("DVD", "007", 100, 12, "One-sided");

            int choice;

            while(true)
            {
                Console.WriteLine("Select [0] to stop: ");
                Console.WriteLine("Select [1] to get storage of capacity: ");
                Console.WriteLine("Select [2] Copying data (files/folders) to the device: ");
                Console.WriteLine("Select [3] to get about free space in storage");
                Console.WriteLine("Select [4] to get full information about storage");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '0')
                {
                    break;
                }
                else if (choice == '1')
                {
                    Console.WriteLine("Storage Flash Capacity: " + storageFlash.GetStorageCapacity() + " MB");
                    Console.WriteLine("Storage HDD Capacity: " + storageHDD.GetStorageCapacity() + " GB");
                    Console.WriteLine("Storage DVD Capacity: " + storageDVD.GetStorageCapacity() + " GB");
                }
                else if (choice == '2')
                {
                    storageFlash.CopyData();
                    storageHDD.CopyData();
                    storageDVD.CopyData();
                }
                else if (choice == '3')
                {
                    storageFlash.GetStorageFreeSpace();
                    storageHDD.GetStorageFreeSpace();
                    storageDVD.GetStorageFreeSpace();
                }
                else if (choice == '4')
                {
                    Console.WriteLine("Storage Flash Info: " + storageFlash.GetStorageInfo());
                    Console.WriteLine("Storage HDD Info: " + storageHDD.GetStorageInfo());
                    Console.WriteLine("Storage DVD Info: " + storageDVD.GetStorageInfo());
                }
            } 
        }
    }
}
