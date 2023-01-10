namespace ConsoleApp1
{
    class Program
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("Usage : MyApp.exe option");
                return;
            }

            string option = args[0];
            switch(option.ToLower())
            {
                case "/v":
                case "/vsebose":
                    verbose = true;
                    Console.WriteLine("verbose : True!");
                    break;
                case "/c":
                    continueOnError = true;
                    Console.WriteLine("continueOnError : True!");
                    break;
                case "/l":
                    logging = true;
                    Console.WriteLine("logging : True!");
                    break;
                default:
                    Console.WriteLine($"Unknown argument: {option}");
                    break;
            }

        }
    }
}