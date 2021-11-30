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




        internal List<Immobile> GetAllImmobili()
        {
            return mockImmobiliRepo.GetAll();
        }

        internal List<Immobile> GetAllBySuperfMin(int min)
        {
            return mockImmobiliRepo.GetByMinArea(min);
        }

        internal List<Immobile> GetAvailable()
        {

            return mockImmobiliRepo.GetAllAvailable();
        }


        internal List<Immobile> GetByCategory(char choice)
        {
            return mockImmobiliRepo.GetByCategory(choice);
        }

        internal void AddNewImmobile(Immobile nuovoImmobile)
        {
            nuovoImmobile.Id = GenerateId();
            mockImmobiliRepo.Add(nuovoImmobile);
        }

        private int GenerateId()
        {
            int numeroImmobili = InMemoryStorage.Immobili.Count;
            int ultimoId = InMemoryStorage.Immobili[numeroImmobili - 1].Id;

            return ultimoId + 1;
        }

        

        internal Immobile GetById(int id)
        {
            List<Immobile> immobili = GetAllImmobili();
            foreach (var item in immobili)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
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
