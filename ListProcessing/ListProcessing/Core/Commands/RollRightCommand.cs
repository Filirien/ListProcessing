namespace ListProcessing.Core
{
    using System;
    using System.Collections.Generic;
 
    public class RollRightCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            var newList = new string[data.Count];

            for (int i = 0; i < data.Count - 1; i++)
            {
                newList[i + 1] = data[i];
            }
            newList[0] = data[data.Count - 1];

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = newList[i];
            }

            Console.WriteLine(string.Join(" ", data));
        }
    }
}