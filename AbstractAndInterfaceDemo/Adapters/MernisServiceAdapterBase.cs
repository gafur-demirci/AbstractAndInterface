using System;
using System.Threading.Tasks;
using AbstractAndInterfaceDemo.Entities;
using MernisServiceReference;

namespace AbstractAndInterfaceDemo.Adapters
{
    public class MernisServiceAdapterBase
    {
        public async Task<TCKimlikNoDogrulaResponse> CheckIfRealPerson(Customer customer)
        {
            var client = new MernisServiceReference.KPSPublicSoapClient();
            return await client.TCKimlikNoDogrulaAsync(TCKimlikNo: Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}