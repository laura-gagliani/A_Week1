using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Interfaces;
using Week1.VR.Core.Models;

namespace Week1.VR.Mock.Repositories
{
    public class MockCustomersRepository : ICustomersRepository
    {
        public bool Add(Customer entity)
        {
            
            InMemoryStorage.Customers.Add(entity);
        }

        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return InMemoryStorage.Customers;
        }

        public Customer GetById(string id)
        {
            foreach (var item in InMemoryStorage.Customers)
            {
                if (item.FiscalCode == id)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
