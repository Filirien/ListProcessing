using System;
using System.Collections.Generic;

namespace ListProcessing.Core
{
    public class DeleteCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            int index = -1;
            bool isNum = int.TryParse(commandParameters[0], out index);

            if (commandParameters.Count != 1 || !isNum)
            {
                throw new Exception("Error: invalid command parameters");
            }

            if (index < 0 || index > data.Count - 1)
            {
                throw new Exception($"Error: invalid index {index}");
            }
            
            data.RemoveAt(index);

            Console.WriteLine(string.Join(" ", data));
        }
    }
}