using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        //PROPRIETA' E STATI
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string TelephoneNumber { get; set; }

        //COSTRUTTORE
        public User(string lastname, string firstname, string email, string password, string telephonenumber)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.Email = email;
            this.Password = password;
            this.TelephoneNumber = telephonenumber;
        }

        //GETTERS
        public string GetEmail()
        {
            return this.Email;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public string GetTelephoneNumber()
        {
            return this.TelephoneNumber;
        }

        //SETTERS
        public string SetLastName()
        {
            return this.LastName;
        }
        public string SetFirstName()
        {
            return this.FirstName;
        }
        public string SetEmail()
        {
            return this.Email;
        }
        public string SetPassword()
        {
            return this.Password;
        }
        public string SetTelephoneNumber()
        {
            return this.TelephoneNumber;
        }

        //METODI
        public void UserPrint()
        {
            Console.WriteLine($@" 
                - Cognome: {this.LastName} 
				- Nome: {this.FirstName}
				- Email: {this.Email}
                - Password: {this.Password}
                - Telefono: {this.TelephoneNumber}");
        }
    }
}
