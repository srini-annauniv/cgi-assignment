using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War.Creators
{
    public interface IWarArenaCreator
    {
        IWarArena Create(int upperXLimit, int upperYLimit);
    }
}
