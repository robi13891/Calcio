using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    class Centrocampista : Calciatore
    {
        public int PassaggiTentati { get; set; }
        public int PassaggiRiusciti { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Centrocampista, Passaggi Tentati: {PassaggiTentati}, Passaggi Riusciti: {PassaggiRiusciti}";
        }
    }
}
