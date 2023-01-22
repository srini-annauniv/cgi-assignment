using Robot.War.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War.Creators
{
    public class WarRobotCreator : IWarRobotCreator
    {
        public IWarRobot Create(int xPosition, int yPostion, RobotFacingDirection robotFacingDirection)
        {
            return new WarRobot(xPosition, yPostion, robotFacingDirection);
        }
    }
}
