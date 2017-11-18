using System;
using System.Collections.Generic;

namespace ListProcessing.Core.Commands
{
    public class AppendCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            if (commandParameters.Count != 1)
            {
                throw new Exception("Error: invalid command parameters");
            }

            var newString = commandParameters[0];
            data.Add(newString);
            System.Console.WriteLine(string.Join(" ", data));
        }
    }
}
