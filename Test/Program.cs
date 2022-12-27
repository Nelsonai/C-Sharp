namespace Name
{


    public class name{
        public string firstNames;
        public string lastNames;
        public int age;

        public void introduce(){
            Console.WriteLine("Her name is " + firstNames + " " + lastNames);
            Console.WriteLine("age is "+ age);
        }
    }
    class program{
        static void Main(string[] args)
        {
            var Esther = new name();
            Esther.firstNames = "Esther";
            Esther.lastNames = "SPAGETTI";
            Esther.age = 18;
            Esther.introduce();
        }
    }
}