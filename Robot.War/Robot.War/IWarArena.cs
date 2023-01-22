using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War
{
    public interface IWarArena
    {
        int UpperXLimit { get; }
        int UpperYLimit { get; }
    }
}
