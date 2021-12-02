using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Agenzia.Core.Entities;

namespace Week1.Agenzia.Mock
{
    internal class MockImmobiliRepository
    {
        //internal List<Immobile> GetAll()
        //{
        //    return InMemoryStorage.Immobili;
        //}

        //internal List<Immobile> GetByMinArea(int min)
        //{
        //    List<Immobile> sublist = new List<Immobile>();

        //    foreach (var item in InMemoryStorage.Immobili)
        //    {
        //        if (item.SuperficieMQ >= min)
        //        {
        //            sublist.Add(item);  
        //        }
        //    }
        //    return sublist; 
        //}

        //internal List<Immobile> GetAllAvailable()
        //{

        //    List<Immobile> sublist = new List<Immobile>();

        //    foreach (var item in InMemoryStorage.Immobili)
        //    {
        //        if (item.Disponibilita)
        //        {
        //            sublist.Add(item);
        //        }
        //    }
        //    return sublist;
        //}

        internal IEnumerable<Immobile> GetUsingLinqWhere(Func<Immobile, bool> filter = null)
        {
            if (filter == null)
            {
                return InMemoryStorage.Immobili;
            }
            else
            {
                IEnumerable<Immobile> filteredList =  InMemoryStorage.Immobili.Where(filter);
                return filteredList;
            }
        }

        //internal List<Immobile> GetByCategory(char choice)
        //{
        //    List<Immobile> sublist = new List<Immobile>();
        //    if (choice == 'a')
        //    {
        //        foreach (var item in InMemoryStorage.Immobili)
        //        {
        //            if (item is Box)
        //            {
        //                sublist.Add(item);
        //            }
        //        }
        //        return sublist;
        //    }

        //    else if (choice == 'b')
        //    {
        //        foreach (var item in InMemoryStorage.Immobili)
        //        {
        //            if (item is Appartamento && item is not Villa)
        //            {
        //                sublist.Add(item);
        //            }
        //        }
        //        return sublist;
        //    }

        //    else if (choice == 'b')
        //    {
        //        foreach (var item in InMemoryStorage.Immobili)
        //        {
        //            if (item is Villa)
        //            {
        //                sublist.Add(item);
        //            }
        //        }
        //        return sublist;
        //    }

        //    return sublist;

        //}

        internal void UpdateAvailability(Immobile im)
        {
            im.Disponibilita = false;
        }

        internal void Delete(Immobile im)
        {
            InMemoryStorage.Immobili.Remove(im);    
        }

        internal void Add(Immobile nuovoImmobile)
        {

            //    [3:55 PM] Alessandra Degan Di Dieco
            //    newBuilding.Id = InMemoryStorage.Buildings.Max(b => b.Id) + 1;

            int newId = InMemoryStorage.Immobili.Max(i => i.Id) +1;
            nuovoImmobile.Id = newId;   

            InMemoryStorage.Immobili.Add(nuovoImmobile);    
        }
    }
}
