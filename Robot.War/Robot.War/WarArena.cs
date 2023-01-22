using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War
{
    public class WarArena : IWarArena
    {
        public int UpperXLimit { get; private set; }
        public int UpperYLimit { get; private set; }

        public WarArena(int upperXLimit, int upperYLimit)
        {
            this.UpperXLimit = upperXLimit;
            this.UpperYLimit = upperYLimit;
        }
    }
}
