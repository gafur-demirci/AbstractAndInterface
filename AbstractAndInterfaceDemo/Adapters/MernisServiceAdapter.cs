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
    public class MernisServiceAdapter : ICustomerCheckService
    { 
        public async bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return await client.TCKimlikNoDogrulaAsync(TCKimlikNo: Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
