using Robot.War.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War
{
    public class WarSpace : IWarSpace
    {
        public WarSpace(IWarArenaCreator warArenaCreator, IWarRobotCreator warRobotCreator)
        {
            WarArenaCreator = warArenaCreator;
            WarRobotCreator = warRobotCreator;
        }

        public IWarArena WarArena { get; set; }
        public IWarRobot WarRobot { get; set; }

        public IWarArenaCreator WarArenaCreator { get; private set; }
        public IWarRobotCreator WarRobotCreator { get; private set; }
    }
}
