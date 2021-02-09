using AbstractAndInterfaceDemo.Abstract;
using AbstractAndInterfaceDemo.Adapters;
using AbstractAndInterfaceDemo.Concrete;
using AbstractAndInterfaceDemo.Entities;
using System;

namespace AbstractAndInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth= new DateTime(1996,2,20), FirstName = "Abdulgafur",
                                                LastName = "Demirci",Id = 1, NationalityId = "2995972478"});
            Console.ReadLine();
        }
    }
}
