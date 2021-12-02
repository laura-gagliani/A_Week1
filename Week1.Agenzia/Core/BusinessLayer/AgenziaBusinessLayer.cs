using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Agenzia.Core.Entities;
using Week1.Agenzia.Mock;

namespace Week1.Agenzia.Core.BusinessLayer
{
    internal class AgenziaBusinessLayer
    {
        //come mai del business layer si creano istanze? perché a seconda del db che gli vogliamo mettere dietro (per ora almeno)
        //ne costruiamo istanze in un modo o nell'altro!

        private readonly MockImmobiliRepository mockImmobiliRepo;

        public AgenziaBusinessLayer(MockImmobiliRepository immobiliMock)
        {
            mockImmobiliRepo = immobiliMock;
        }




        internal IEnumerable<Immobile> GetAllImmobili()
        {
            //return mockImmobiliRepo.GetAll();

            return mockImmobiliRepo.GetUsingLinqWhere();
        }

        internal IEnumerable<Immobile> GetAllBySuperfMin(int min)
        {
            //return mockImmobiliRepo.GetByMinArea(min);

            return mockImmobiliRepo.GetUsingLinqWhere(imm => imm.SuperficieMQ >= min);
        }

        internal IEnumerable<Immobile> GetAvailable()
        {

            //return mockImmobiliRepo.GetAllAvailable();

            return mockImmobiliRepo.GetUsingLinqWhere(imm => imm.Disponibilita);


        }


        internal IEnumerable<Immobile> GetByCategory(char choice)
        {
            //return mockImmobiliRepo.GetByCategory(choice);

            if (choice == 'a')
                return mockImmobiliRepo.GetUsingLinqWhere(im => im is Box);

            else if (choice == 'b')
                return mockImmobiliRepo.GetUsingLinqWhere(im => im is Appartamento && im is not Villa);

            else
                return mockImmobiliRepo.GetUsingLinqWhere(im => im is Villa);



        }

        internal void AddNewImmobile(Immobile nuovoImmobile)
        {
            mockImmobiliRepo.Add(nuovoImmobile);  


        }

      


        internal Immobile GetById(int id)
        {
            //List<Immobile> immobili = GetAllImmobili().ToList();
            //foreach (var item in immobili)
            //{
            //    if (item.Id == id)
            //    {
            //        return item;
            //    }
            //}
            //return null;

            return mockImmobiliRepo.GetUsingLinqWhere(im => im.Id == id).SingleOrDefault();
            
        }

        internal void DeleteImmobile(Immobile im)
        {
            mockImmobiliRepo.Delete(im);
        }

        internal void UpdateAvailability(Immobile im)
        {
            mockImmobiliRepo.UpdateAvailability(im);
        }
    }
}
