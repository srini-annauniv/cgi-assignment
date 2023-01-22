using Robot.War.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War
{
    public class WarRobot : IWarRobot
    {
        public WarRobot(int xPostion, int yPostion, RobotFacingDirection robotFacingDirection)
        {
            this.XPostion = xPostion;
            this.YPostion = yPostion;
            this.RobotFacingDirection = robotFacingDirection;
        }
        public int XPostion { get; set;}
        public int YPostion { get; set; }
        public RobotFacingDirection RobotFacingDirection { get; set; }
        public IWarArena WarArena { get; set; }

        public bool EnterWarArena(IWarArena warArena)
        {
            if (warArena == null || this.XPostion > warArena.UpperXLimit || this.YPostion > warArena.UpperYLimit)
            {
                return false;
            }

            this.WarArena = warArena;
            return true;

        }

        public void Move()
        {
            if (this.WarArena == null)
                return;
            switch (this.RobotFacingDirection)
            {
                case RobotFacingDirection.N:
                    if (this.YPostion < this.WarArena.UpperYLimit)
                    {
                        this.YPostion++;
                    }
                    break;
                case RobotFacingDirection.E:
                    if (this.XPostion < this.WarArena.UpperXLimit)
                    {
                        this.XPostion++;
                    }
                    break;
                case RobotFacingDirection.S:
                    if (this.YPostion > 0)
                    {
                        this.YPostion--;
                    }
                    break;
                case RobotFacingDirection.W:
                    if (this.XPostion > 0)
                    {
                        this.XPostion--;
                    }
                    break;
            }
        }

        public void Rotate(RobotRotateDirection robotRotateDirection)
        {
            switch(robotRotateDirection)
            {
                case RobotRotateDirection.Right:
                    {
                        switch (this.RobotFacingDirection)
                        {
                            case RobotFacingDirection.N:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.E;
                                    break;
                                }
                            case RobotFacingDirection.E:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.S;
                                    break;
                                }
                            case RobotFacingDirection.S:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.W;
                                    break;
                                }
                            case RobotFacingDirection.W:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.N;
                                    break;
                                }
                            default: break;
                        }
                        break;
                    }
                case RobotRotateDirection.Left:
                    {
                        switch (this.RobotFacingDirection)
                        {
                            case RobotFacingDirection.N:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.W;
                                    break;
                                }
                            case RobotFacingDirection.W:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.S;
                                    break;
                                }
                            case RobotFacingDirection.S:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.E;
                                    break;
                                }
                            case RobotFacingDirection.E:
                                {
                                    this.RobotFacingDirection = RobotFacingDirection.N;
                                    break;
                                }
                            default: break;
                        }
                        break;
                    }
                default:break;
            }
        }
    }
}
