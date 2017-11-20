namespace ListProcessing.Core
{
    using System;
    using System.Linq;
    using ListProcessing.Core.Commands;
    using System.Collections.Generic;

    public class CommandInterpreter
    {
        public void InterpretCommand(List<string> commandParameters, List<string> data)
        {
            string command = commandParameters[0];
            commandParameters = commandParameters.Skip(1).ToList();
            switch (command.ToLower())
            {
                case "append":
                    var append = new AppendCommand();
                    append.Execute(commandParameters, data);
                    break;

                case "insert":
                    var insertCommand = new InsertCommand();
                    insertCommand.Execute(commandParameters, data);
                    break;

                case "delete":
                    var deleteCommand = new DeleteCommand();
                    deleteCommand.Execute(commandParameters, data);
                    break;

                case "roll":
                    if (commandParameters.Count != 1)
                    {
                        throw new Exception("Error: invalid command parameters");
                    }

                    if (commandParameters[0].ToLower() == "left")
                    {
                        var rollLeftCommand = new RollLeftCommand();
                        rollLeftCommand.Execute(commandParameters, data);
                    }

                    if (commandParameters[0].ToLower() == "right")
                    {
                        var rollRightCommand = new RollRightCommand();
                        rollRightCommand.Execute(commandParameters, data);
                    }
                    break;

                case "prepend":
                    var prependCommand = new PrependCommand();
                    prependCommand.Execute(commandParameters, data);
                    break;

                case "count":
                    var countCommand = new CountCommand();
                    countCommand.Execute(commandParameters, data);
                    break;

                case "sort":
                    var sortCommand = new SortCommand();
                    sortCommand.Execute(commandParameters, data);
                    break;

                case "reverse":
                    var reverseCommand = new ReverseCommand();
                    reverseCommand.Execute(commandParameters, data);
                    break;

                default:
                    Console.WriteLine("Error: invalid command");
                    break;

            }
        }
    }
}
