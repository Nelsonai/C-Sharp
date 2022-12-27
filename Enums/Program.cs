namespace MyNamespace
{
    // Enums are used for declaring constants
    public enum transportationMethod
    {
        byRoad = 1,
        byWater = 2,
        byAir = 3
    }
    class program
    {
        static void Main(string[] args)
        {
            var method = transportationMethod.byRoad;
            Console.WriteLine((int)method);
            // Console.WriteLine(method);

            // 
            var methodNum = 2;
            Console.WriteLine((transportationMethod)methodNum);


        }
    }
}