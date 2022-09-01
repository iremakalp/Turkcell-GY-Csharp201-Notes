using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Customer
    {
        public int id;
        private string firstName;
        public string lastName;
        public string city;

        // tolower  kullanildigi icin console ekraninda ad kismina
        // ne yazarsak yazalim yazdirirken tüm harfleri kucuk yazar

        // toupper kullanildigi icinde soyadi ekrana yazdirirken tum harfleri buyuk yazar
        public string FirstName { get => firstName; set => firstName = value.ToLower(); }
        public string LastName 
        { 
            get => lastName;
            set => lastName=value.ToUpper(); 
        }
    }
}
