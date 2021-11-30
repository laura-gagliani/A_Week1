using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Agenzia.Core.Entities
{
    internal class Box : Immobile
    {
        public int PostiAuto { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" - Numero di posti auto: {PostiAuto}";
        }
    }
}
