using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    class Difensore : Calciatore
    {
        public int TackleRiusciti { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Difensore, Tackle Riusciti: {TackleRiusciti}";
        }
    }

}
