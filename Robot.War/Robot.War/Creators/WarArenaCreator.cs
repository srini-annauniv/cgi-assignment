using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War.Creators
{
    public class WarArenaCreator : IWarArenaCreator
    {
        public IWarArena Create(int upperXLimit, int upperYLimit)
        {
            return new WarArena(upperXLimit, upperYLimit);
        }
    }
}
