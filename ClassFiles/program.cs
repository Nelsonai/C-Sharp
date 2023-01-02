using ClassFiles.Math;

namespace CLassFiles
{
    class program{
        static void Main(string[] args)
        {
            var Nelson = new Character();
            Nelson.FirstName = "Nelson";
            Nelson.LastName  = "Oriaku";
            Nelson.Introduce();    

            var Calc = new Calculator();
            Console.WriteLine(Calc.add(4,7));
        }
    }
}