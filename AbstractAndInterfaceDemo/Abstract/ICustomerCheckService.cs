using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System;
using AbstractAndInterfaceDemo.Entities;

namespace AbstractAndInterfaceDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
        
    }
}
