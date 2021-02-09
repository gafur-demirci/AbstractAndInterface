using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using AbstractAndInterfaceDemo.Entities;

namespace AbstractAndInterfaceDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to DataBase : " + customer.FirstName);
        }
    }
}
