using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Homework15
{
    public class User
    {
        private int Id;
        public string Name;
        public string Email;
        private string Password;
        public DateTime Birthday;
        public User()
        {

        }
        public User(int Id, string Name, DateTime Birthday)
        {
            this.Id = Id;
            this.Name = Name;
            this.Birthday = Birthday;
        }
        public User(int Id, string Name, string Email, string Password, DateTime Birthday)
        {
            this.Id= Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Birthday = Birthday;
        }

        public string PrintInfo()
        {
            return $"Имя: {Name}, Почта: {Email}, Дата рождения: {Birthday}";
        }
    }
}
