using Robot.War.Creators;
using Robot.War.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Robot.War.ConsoleApp
{
    public class Program
    {
        static bool exitProgram = false;
        static IWarSpace WarSpace { get; set; }
        static IWarArenaCreator WarArenaCreator { get; set; }
        static IWarRobotCreator WarRobotCreator { get; set; }

        public static void Main(string[] args)
        {
            BuildSetup();
            Run();
        }

        private static void BuildSetup()
        {
            WarArenaCreator = new WarArenaCreator();
            WarRobotCreator = new WarRobotCreator();
            WarSpace = new WarSpace(WarArenaCreator, WarRobotCreator);
        }

        private static void AddWarArena(int upperXLimit, int upperYLimit)
        {
            WarSpace.WarArena = WarArenaCreator.Create(upperXLimit, upperYLimit);
        }

        private static void AddWarRobot(int xPosition, int yPostion, RobotFacingDirection robotFacingDirection)
        {
            WarSpace.WarRobot =  WarRobotCreator.Create(xPosition, yPostion, robotFacingDirection);
        }

        private static void PrintWarRobotPostion()
        {
                Console.WriteLine($"{WarSpace.WarRobot.XPostion} {WarSpace.WarRobot.YPostion} {WarSpace.WarRobot.RobotFacingDirection }");
        }
        private static void Run()
        {
            while (!exitProgram)
            {
                string commandLineInput = Console.ReadLine();
                if (commandLineInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    exitProgram = true;
                ProcessInput(commandLineInput);
            }

            Console.ReadKey();
        }
        private static void ProcessInput(string commandLineInput)
        {
            switch (CommandProcessor.GetCommandType(commandLineInput))
            {
                case CommandType.CreateArena:
                    ProcessInputCreateAarena(commandLineInput);
                    break;
                case CommandType.RobotEntry:
                    ProcessInputRobotEntry(commandLineInput);
                    break;
                case CommandType.TraverseRobot:
                    ProcessInputTraverseRobot(commandLineInput);
                    break;
                default:
                    Console.WriteLine("Invalid Input Parameters");
                    break;
            }
        }

        private static void ProcessInputCreateAarena(string commandLineInput)
        {
            string [] arenaUpperLimitDimensions = commandLineInput.Split(' ');
            AddWarArena(Convert.ToInt32(arenaUpperLimitDimensions[0]), Convert.ToInt32(arenaUpperLimitDimensions[1]));
        }

        private static void ProcessInputRobotEntry(string commandLineInput)
        {
            string[] robotEntryPostion = commandLineInput.Split(' ');
            AddWarRobot(
                Convert.ToInt32(robotEntryPostion[0])
               ,Convert.ToInt32(robotEntryPostion[1])
               ,CommandProcessor.ConvertToRobertDirection(Convert.ToChar(robotEntryPostion[2])));
            WarSpace.WarRobot.EnterWarArena(WarSpace.WarArena);
        }

        private static void ProcessInputTraverseRobot(string commandLineInput)
        {
            char[] traversalCommands = commandLineInput.ToCharArray();
            foreach(char command in traversalCommands)
            {
                switch(CommandProcessor.GetRobotCommandType(command))
                {
                    case RobotCommandType.Move:
                        WarSpace.WarRobot.Move();
                        break;
                    case RobotCommandType.Rotate:
                        WarSpace.WarRobot.Rotate(CommandProcessor.ConvertToRobertRotateDirection(command));
                        break;
                        throw new ArgumentException("Invalid Command Expresssion: {commandLineInput}");
                }
            }
            PrintWarRobotPostion();
        }

    }
}
