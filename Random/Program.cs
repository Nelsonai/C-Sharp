namespace Name
{
    class program{
        static void Main(string[] args)
        {
            var i = 0;
            var random = new Random();  
            while(i<10){  
                Console.WriteLine(random.Next());
                i++;
            }
        }
    }
}