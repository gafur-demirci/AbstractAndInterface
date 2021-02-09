using AbstractAndInterfaceDemo.Abstract;
using AbstractAndInterfaceDemo.Entities;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System;
using MernisServiceReference;

namespace AbstractAndInterfaceDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
