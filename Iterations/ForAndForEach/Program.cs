namespace Name
{
    class program{
        static void Main(string[] args)
        {
            // for(var i=1; i<=10; i++)
            // {
            //     if(i%2==0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            
            Console.WriteLine("......................................");
            Console.WriteLine("......................................");

            // var name = "Onyekachi Oriaku";
            // for(int i=0; i<name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            Console.WriteLine("......................................");
            Console.WriteLine("......................................");
            Console.WriteLine("A foreach is better");

            // foreach (var item in name)
            // {
            //     Console.WriteLine(item);
            // }
            Console.WriteLine("......................................");
            Console.WriteLine("......................................");
            Console.WriteLine("Using for each with Lists");

            var numbers = new int[]{1,2,3};
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}