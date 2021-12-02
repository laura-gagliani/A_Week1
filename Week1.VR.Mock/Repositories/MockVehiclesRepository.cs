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
            List<Vehicle> availableVehicles = new List<Vehicle>();  
            bool isAvailable;


            foreach (Vehicle v in InMemoryStorage.Vehicles)
            {
                isAvailable = true;

                foreach (Rental r in InMemoryStorage.Rentals)
                {
                    if ((DateTime.Today - TimeSpan.FromDays(r.Duration) <= r.StartingDate) && (r.StartingDate <= DateTime.Today) && v.Plate == r.VehiclePlate)
                    {   //se il rental è attivo e la targa del rental attivo coincide con il veicolo considerato -> allora il veicolo non è disponibile
                        isAvailable = false;
                    }
                }
                if (isAvailable)
                {
                    availableVehicles.Add(v);
                }
            }
            return availableVehicles;
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
