using Robot.War.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War
{
    public interface IWarSpace
    {
        IWarArena WarArena { get; set; }
        IWarRobot WarRobot { get; set; }

        IWarArenaCreator WarArenaCreator { get; }
        IWarRobotCreator WarRobotCreator { get; }
    }
}
