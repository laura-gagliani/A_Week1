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
            return InMemoryStorage.Vehicles;
        }

        public List<Vehicle> GetAvailableVehicles()
        {
            List<Vehicle> vehicles = InMemoryStorage.Vehicles;

            foreach (var item in InMemoryStorage.Vehicles)
            {

            }
        }

        public Vehicle GetById(string id)
        {
            foreach (var item in InMemoryStorage.Vehicles)
            {
                if (item.Plate == id)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
