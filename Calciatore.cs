using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    class Calciatore
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public String DataDiNascita { get; set; }
        public int NumeroMaglia { get; set; }
        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
