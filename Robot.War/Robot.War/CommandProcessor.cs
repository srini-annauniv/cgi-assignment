using Robot.War.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Robot.War
{
    public static class CommandProcessor
    {
        static readonly string RegExCreateArenaPattern = @"[0-9]+ [0-9]+";
        static readonly string RegExCreateRobotPattern = @"[0-9]+ [0-9]+ [neswNESW]+";
        static readonly string RegExRobotTraversalPattern = @"[mMlLrR]+";

        public static bool IsValid(string commandLine)
        {
            if (Regex.Match(commandLine, RegExCreateArenaPattern).Success || Regex.Match(commandLine, RegExCreateRobotPattern).Success
                || Regex.Match(commandLine, RegExRobotTraversalPattern).Success) 
                return true;
            return false;
        }

        public static CommandType GetCommandType(string commandLine)
        {
            if (Regex.Match(commandLine, RegExCreateRobotPattern).Success)
                return CommandType.RobotEntry;
            if (Regex.Match(commandLine, RegExCreateArenaPattern).Success)
                return CommandType.CreateArena;
            if (Regex.Match(commandLine, RegExRobotTraversalPattern).Success)
                return CommandType.TraverseRobot;
            return CommandType.InValidCommand;
        }
        public static RobotFacingDirection ConvertToRobertDirection(char direction)
        {
            switch(direction)
            {
                case 'n':
                case 'N':
                    return RobotFacingDirection.N;
                case 'e':
                case 'E':
                    return RobotFacingDirection.E;
                case 's':
                case 'S':
                    return RobotFacingDirection.S;
                case 'w':
                case 'W':
                    return RobotFacingDirection.W;
            }
            throw new ArgumentException($"Invalid Direction {direction}");
        }
        public static RobotRotateDirection ConvertToRobertRotateDirection(char roateDirection)
        {
            switch (roateDirection)
            {
                case 'l':
                case 'L':
                    return RobotRotateDirection.Left;
                case 'r':
                case 'R':
                    return RobotRotateDirection.Right;
            }
            throw new ArgumentException($"Invalid RotateDirection {roateDirection}");
        }
        public static RobotCommandType GetRobotCommandType(char command)
        {
            switch (command)
            {
                case 'm':
                case 'M':
                    return RobotCommandType.Move;
                case 'r':
                case 'R':
                case 'l':
                case 'L':
                    return RobotCommandType.Rotate;

            }
            throw new ArgumentException($"Invalid Command {command}");
        }


    }
}
