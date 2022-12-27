namespace Name
{
    class program{
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            // Output of a would be 10, and b would be 11\
            Console.WriteLine(string.Format("a: {0}, b: {1}", a,b));

            // But thats not the same with arrays

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 4;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }    
}