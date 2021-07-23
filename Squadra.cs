using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    class Squadra
    {
        public string Nome { get; set; }
        public string DataFondazione { get; set; }
        public string CampionatoDisputatato { get; set; }
        public string Presidente { get; set; }
        public string Allenatore { get; set; }
        public List<Calciatore> Rosa { get; set; }
        public List<Calciatore> Titolari { get; set; }


    }
}
