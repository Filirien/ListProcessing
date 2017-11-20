namespace ListProcessing
{
    using ListProcessing.Core;

    class StartUp
    {
        static void Main(string[] args)
        {
            var interpreter = new CommandInterpreter();
            var engine = new Engine(interpreter);
            engine.Run();
        }
    }
}
