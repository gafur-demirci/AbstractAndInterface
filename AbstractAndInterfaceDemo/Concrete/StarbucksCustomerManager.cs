using AbstractAndInterfaceDemo.Abstract;
using AbstractAndInterfaceDemo.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfaceDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

    }
}
