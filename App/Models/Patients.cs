using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Patients
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public Patients(string firstName, string lastName, string email, string pesel, string phoneNumber, string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Pesel = pesel;
            PhoneNumber = phoneNumber;
            Adress = adress;
        }
    }
}
