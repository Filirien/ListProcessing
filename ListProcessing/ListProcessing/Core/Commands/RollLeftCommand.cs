namespace ListProcessing.Core
{
    using System;
    using System.Collections.Generic;

    public class RollLeftCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            var newList = new string[data.Count];

            for (int i = 0; i < data.Count; i++)
            {
                newList[i] = data[(i + 1) % data.Count];
            }

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = newList[i];
            }
            
            Console.WriteLine(string.Join(" ", data));
        }
    }
}