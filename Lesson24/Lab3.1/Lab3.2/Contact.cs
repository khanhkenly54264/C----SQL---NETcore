using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    internal class Contact
    {
        private int id;
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string address;
        
        public Contact()
        {

        }

        public Contact(int id, string firstname, string lastname, string email, string phone, string address)
        {
            this.Id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        public void Display()
        {
            Console.WriteLine("Ma so:" + id);
            Console.WriteLine("Ho va ten:{0} {1}", firstname, lastname);
            Console.WriteLine("Dia chi:" + address);
            Console.WriteLine("Dien thoai:" + phone);
            Console.WriteLine("Email:" + email);
        }
    }
}
