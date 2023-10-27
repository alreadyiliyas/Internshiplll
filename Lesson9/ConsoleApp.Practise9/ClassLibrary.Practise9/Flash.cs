using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise9
{
    public class Flash : Storage
    {
        private int storageCapacity; // Объем памяти в МБ
        private int usbSpeed; // Скорость USB 3.0 в Мб/сек

        public Flash(string storageName, string storageModel, int storageCapacity, int usbSpeed) : base(storageName, storageModel)
        {
            this.storageCapacity = storageCapacity;
            this.usbSpeed = usbSpeed;
        }

        public override int GetStorageCapacity()
        {
            return storageCapacity;
        }

        public int GetUsbSpeed()
        {
            return usbSpeed;
        }

        // Дополнительный метод для получения полной информации
        public string GetStorageInfo()
        {
            return $"Name: {storageName}, Model: {storageModel}, Capacity: {storageCapacity} MB, USB Speed: {usbSpeed} MB/s";
        }
    }
}
