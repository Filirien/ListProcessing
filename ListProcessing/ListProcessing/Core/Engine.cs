using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProcessing.Core
{
    public class Engine
    {
        private readonly CommandInterpreter commandInterpreter;

        public Engine(CommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        { 
            List<string> data = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                try
                {
                    List<string> input = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    if (input[0] == "end")
                    {
                        if (input.Count != 1)
                        {
                            throw new Exception("Error: invalid command parameters");
                        }

                        Console.WriteLine("Finished");
                        break;
                    }

                    this.commandInterpreter.InterpretCommand(input, data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
