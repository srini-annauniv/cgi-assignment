using Robot.War.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War
{
    public interface IWarRobot
    {
        int XPostion { get; }
        int YPostion { get; }
        RobotFacingDirection RobotFacingDirection { get; }
        IWarArena WarArena { get; set; }
        void Move();
        void Rotate(RobotRotateDirection robotRotateDirection);
        bool EnterWarArena(IWarArena warArena);
    }
}
