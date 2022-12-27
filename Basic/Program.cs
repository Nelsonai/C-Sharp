namespace first
{
    class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("whatsupp");
        var name = "Kachi";
        char character = 'f';
        Console.WriteLine(name + "oriaku");
        Console.WriteLine(character);
        // var firstValue = "Onyekachi";
        // var secondValue = "Oriaku";
        // Console.WriteLine("{0} {1}", firstValue, secondValue);

        string u = "1";
        int i = Convert.ToInt32(u);
        // Console.WriteLine(i);
        int n = 1000;
        byte f = (byte)n;
        Console.WriteLine(f);
        // TRY EXCEPT FOR C#
        try
        {
            var t = "1234";
            byte j = Convert.ToByte(t);
            Console.WriteLine(j);
        }
        catch (System.Exception)
        {
            Console.WriteLine("This number cannot be converted to a byte");
        }

    }
}
}
