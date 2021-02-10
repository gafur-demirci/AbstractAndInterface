using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System;
using AbstractAndInterfaceDemo.Entities;
using MernisServiceReference;

namespace AbstractAndInterfaceDemo.Abstract
{
    public partial interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
        
    }
}
