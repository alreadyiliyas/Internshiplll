using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise9
{
    public class HDD : Storage
    {
        private int storageCapacity; // Объем памяти в ГБ
        private int usbSpeed; // Скорость USB 2.0 в Мб/сек
        private int partitionCount; // Количество разделов

        public HDD(string storageName, string storageModel, int storageCapacity, int usbSpeed, int partitionCount) : base(storageName, storageModel)
        {
            this.storageCapacity = storageCapacity;
            this.usbSpeed = usbSpeed;
            this.partitionCount = partitionCount;
        }

        public override int GetStorageCapacity()
        {
            return storageCapacity;
        }

        public int GetUsbSpeed()
        {
            return usbSpeed;
        }

        public int GetPartitionCount()
        {
            return partitionCount;
        }

        // Дополнительный метод для получения полной информации
        public string GetStorageInfo()
        {
            return $"Name: {storageName}, Model: {storageModel}, Capacity: {storageCapacity} GB, USB Speed: {usbSpeed} MB/s, Partitions: {partitionCount}";
        }
    }
}
