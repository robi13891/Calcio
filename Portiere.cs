using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    class Portiere : Calciatore
    {
        public int GoalSubiti { get; set; }
        public int RigoriParati { get; set; }

        public override string ToString()
        {
            return base.ToString() +  $", Portiere, Goal subiti: {GoalSubiti}, Rigori Parati: {RigoriParati}";
        }
    }
}
