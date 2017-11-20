namespace ListProcessing.Core
{
    using System;
    using System.Collections.Generic;

    public class CountCommand
    {
        public void Execute(List<string> commandParameters, List<string> data)
        {
            if (commandParameters.Count != 1)
            {
                throw new Exception("Error: invalid command parameters");
            }

            var counter = 0;

            foreach (var d in data)
            {
                if (d == commandParameters[0])
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}