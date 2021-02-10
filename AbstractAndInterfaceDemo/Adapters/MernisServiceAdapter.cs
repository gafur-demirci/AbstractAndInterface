using AbstractAndInterfaceDemo.Abstract;
using AbstractAndInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MernisServiceReference;

namespace AbstractAndInterfaceDemo.Adapters
{
    public class MernisServiceAdapter : MernisServiceAdapterBase, ICustomerCheckService
    {
        public new bool CheckIfRealPerson(Customer customer) => throw new NotImplementedException();

        public void Save(Customer customer) => throw new NotImplementedException();
    }
}
