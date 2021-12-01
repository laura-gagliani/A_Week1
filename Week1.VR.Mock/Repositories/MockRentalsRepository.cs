using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Interfaces;
using Week1.VR.Core.Models;

namespace Week1.VR.Mock.Repositories
{
    public class MockRentalsRepository : IRentalsRepository
    {
        public bool Add(Rental entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Rental entity)
        {
            throw new NotImplementedException();
        }

        public List<Rental> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rental GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Rental entity)
        {
            throw new NotImplementedException();
        }
    }
}
