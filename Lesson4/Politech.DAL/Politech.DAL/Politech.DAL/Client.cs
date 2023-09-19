using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politech.DAL
{
    public class Client
    {
        //Занято место памяти
        int age;
        //Пустое значение

        //Развернутое свойство
        public int Id { get; set; }
        public DateTime CreatedData { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string LName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1} {2}", FName, SName, LName);
            }
        }
        public string ShortName
        {
            get
            {
                return string.Format("{0} {1}. {2}.", FName, SName[0], LName[0]);
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Sex { get; set; }
        public DateTime Dob { get; set; }  
        public int Age 
        { 
            get 
            {
                return (DateTime.Now.Year - Dob.Year);    
            } 
        }
        public string PersonalImage { get; set; }
        public Address Address { get; set;}
    }
}
