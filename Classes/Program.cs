namespace Name
{

    public class polygon{
        public string polygon1;
        // public string polygon2;
        

        public void shapes(){
            Console.WriteLine("this is a " + " " + polygon1);
            // Console.WriteLine("this is a " + " " + polygon2);
        }
    }
    class program{
        public static void Main(string[] args)
        {
            var triangle = new polygon();
            var pentagon = new polygon();

            triangle.polygon1 = "triangle";
            pentagon.polygon1 = "pentagon";
            
            triangle.shapes();
            pentagon.shapes();
        }
    }
}