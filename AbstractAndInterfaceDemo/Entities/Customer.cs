using AbstractAndInterfaceDemo.Abstract;
using System;

namespace AbstractAndInterfaceDemo.Entities
{

    public class Customer :IEntity                 // Müşteri Class'ı
    {
        public int Id { get; set; }                // Müşteri No
        public string FirstName { get; set; }      // Ad
        public string LastName { get; set; }       // Soyad
        public DateTime DateOfBirth { get; set; }  // Doğum Tarihi
        public string NationalityId { get; set; }  // TC kimlik no

    }
    
}