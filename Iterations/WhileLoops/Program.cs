namespace Name
{
    class program{
         static void Main(string[] args)
        {
            // var i = 0;
            // while(i <= 10){
            //     if(i%2==0){
            //         Console.WriteLine(i);
            //     }
            //     i++;
            // }
            Console.WriteLine("Press stop to terminate the program");
            while (true){
                Console.WriteLine("What is your Name: ");
                var userInput = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(userInput) || userInput == "stop" || userInput == "Stop"){
                    break;
                }
                Console.WriteLine("Hello " + userInput);
            }  
        }
    }
}