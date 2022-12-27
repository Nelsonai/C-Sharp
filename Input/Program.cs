namespace Name
{
    class program{
        static void Main(string[] args)
        {
            Console.Write("Type your name: ");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)){
                Console.WriteLine("You didnt input a name.");
                Environment.Exit(0);
            }
            Console.WriteLine("Hello, " + input);

        }
    }
} 