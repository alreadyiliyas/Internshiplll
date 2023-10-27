    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise9
{
    public class DVD : Storage
    {
        private int storageCapacity; // Объем памяти в ГБ
        private int readWriteSpeed; // Скорость чтения/записи в Мб/сек
        private string type; // Тип диска (односторонний/двусторонний)

        public DVD(string storageName, string storageModel, int storageCapacity, int readWriteSpeed, string type) : base(storageName, storageModel)
        {
            this.storageCapacity = storageCapacity;
            this.readWriteSpeed = readWriteSpeed;
            this.type = type;
        }

        public override int GetStorageCapacity()
        {
            return storageCapacity;
        }

        public int GetReadWriteSpeed()
        {
            return readWriteSpeed;
        }

        public string GetDiskType()
        {
            return type;
        }

        // Дополнительный метод для получения полной информации
        public string GetStorageInfo()
        {
            return $"Name: {storageName}, Model: {storageModel}, Capacity: {storageCapacity} GB, Read/Write Speed: {readWriteSpeed} MB/s, Type: {type}";
        }
    }
}
