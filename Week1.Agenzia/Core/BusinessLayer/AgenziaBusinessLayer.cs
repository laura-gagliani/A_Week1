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

        private readonly MockImmobiliRepository mockRepository;

        public AgenziaBusinessLayer(MockImmobiliRepository immobiliMock)
        {
            mockRepository = immobiliMock; 
        }




        internal List<Immobile> GetAllImmobili()
        {

            throw new NotImplementedException();
        }
    }
}
