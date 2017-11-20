namespace ListProcessing.Core
{
    using System;
    using System.Collections.Generic;

    public class InsertCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            int index = -1;
            bool isNum = int.TryParse(commandParameters[0], out index);

            if (commandParameters.Count != 2 || !isNum)
            {
                throw new Exception("Error: invalid command parameters");
            }

            if (index < 0 || index > data.Count - 1)
            {
                throw new Exception($"Error: invalid index {index}");
            }

            var stringForInsert = commandParameters[1];
            data.Insert(index, stringForInsert);
            Console.WriteLine(string.Join(" ", data));
        }
    }
}