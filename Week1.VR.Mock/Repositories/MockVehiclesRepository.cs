using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.VR.Core.Interfaces;
using Week1.VR.Core.Models;

namespace Week1.VR.Mock.Repositories
{
    public class MockVehiclesRepository : IVehiclesRepository
    {
        public bool Add(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAll()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
