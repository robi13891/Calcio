using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    class Attaccante : Calciatore
    {
        public int GoalRealizzati { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Attaccante, Goal Realizzati: {GoalRealizzati}";
        }
    }

    
}
