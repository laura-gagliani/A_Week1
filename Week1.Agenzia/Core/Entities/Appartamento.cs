using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Agenzia.Core.Entities
{
    internal class Appartamento : Immobile
    {
        public int Vani { get; set; }
        public int Bagni { get; set; }


        public override string ToString()
        {
            return base.ToString() + $" - Numero di vani: {Vani} Numero di bagni: {Bagni}";
        }
    }
}
