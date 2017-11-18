using System;
using ListProcessing.Core.Commands;
using System.Collections.Generic;
using System.Linq;

namespace ListProcessing.Core
{
    public class CommandInterpreter
    {
        public void InterpretCommand(List<string> commandParameters, List<string> data)
        {
            string command = commandParameters[0];
            commandParameters = commandParameters.Skip(1).ToList();
            switch (command.ToLower())
            {
                case "append":
                    var registerUser = new AppendCommand();
                    registerUser.Execute(commandParameters, data);
                    break;

                    //TODO commands
                default:
                    Console.WriteLine("Error: invalid command");
                    break;

            }
        }
    }
}
