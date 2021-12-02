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
            //generate id
            int newId;
            int numberOfRentals = InMemoryStorage.Rentals.Count;

            if (numberOfRentals == 0)
            {
                newId = 1;
            }
            else
            {
                int max = 0;
                foreach (var item in InMemoryStorage.Rentals)
                {
                    if(item.RentalId > max)
                    {
                        max = item.RentalId;
                    }
                }
                newId = max +1;

            }
            //assign id
            entity.RentalId = newId;

            //add to list
            InMemoryStorage.Rentals.Add(entity);    
            return true;
        }

        public bool Delete(Rental entity)
        {
            throw new NotImplementedException();
        }

        public List<Rental> GetAll()
        {
            return InMemoryStorage.Rentals;

        }

        public Rental GetById(int id)
        {
            foreach (var item in InMemoryStorage.Rentals)
            {
                if (item.RentalId == id)
                {
                    return item;    
                }
            }
            return null;
        }

        public List<Rental> GetByUser(string userId)
        {
            throw new NotImplementedException();
        }

        public List<Rental> GetByVehicle(string vehicleId)
        {
            List<Rental> sublist = new List<Rental> ();
            foreach (var item in InMemoryStorage.Rentals)
            {
                if (item.VehiclePlate == vehicleId)
                {
                    sublist.Add(item);  
                }
            }
            return sublist; 
        }

        public List<Rental> GetRentalsInProgress()
        {
            List<Rental> sublist = new List<Rental>();
            foreach (var item in InMemoryStorage.Rentals)
            {
                if ((DateTime.Today - TimeSpan.FromDays(item.Duration) <= item.StartingDate) && (item.StartingDate <= DateTime.Today)) 
                {
                    sublist.Add(item);
                }
            }
            return sublist;
        }

        public bool Update(Rental entity)
        {
            throw new NotImplementedException();
        }
    }
}
