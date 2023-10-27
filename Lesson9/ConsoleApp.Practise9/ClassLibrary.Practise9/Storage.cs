using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.Practise9
{
    public abstract class Storage
    {
        protected string storageName;
        protected string storageModel;
        protected int dataSize;
        public Storage(string StorageName, string StorageModel)
        {
            storageName = StorageName;
            storageModel = StorageModel;
        }
        public int GetRandomDataSize()
        {
            if (dataSize != 0)
            {
                return dataSize;
            }
            // Иначе сгенерируем случайный размер данных
            dataSize = new Random().Next(24, 101);
            return dataSize;
        }
        public abstract int GetStorageCapacity();
        
        public void CopyData()
        {
            int dataSize = GetRandomDataSize();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Copying " + dataSize + " MB of data from " + storageName + " " + storageModel + " to device");
            int totalSize = 0;
            int updateInterval = dataSize / 10;
            for (int i = 0; i <= dataSize; i++)
            {
                Thread.Sleep(80);
                totalSize = i;
                if (i % updateInterval == 0)
                {
                    Console.WriteLine($"Copying... {i * 100 / dataSize}% completed.");
                }
            }

            Console.WriteLine("Data copied successfully!");
        }
        public void GetStorageFreeSpace()
        {
            int freeSpace = GetStorageCapacity() - dataSize;
            Console.WriteLine("Free space " + freeSpace + " MB, " + storageName);
        }
    }
}
