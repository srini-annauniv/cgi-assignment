using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War.Enums
{
    public enum RobotFacingDirection
    {
        [Description("North")]
        N = 0,
        [Description("South")]
        S = 1,
        [Description("West")]
        W = 2,
        [Description("East")]
        E = 3
    }
}
