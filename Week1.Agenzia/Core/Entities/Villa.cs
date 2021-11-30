using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Agenzia.Core.Entities
{
    internal class Villa : Appartamento
    {
        public int MqGiardino { get; set; }


        public override string ToString()
        {
            return base.ToString() + $" - Giardino: {MqGiardino} mq";
        }
    }
}
