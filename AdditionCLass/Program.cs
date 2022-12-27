namespace Name
{


    public class addition{
        public int add(int a, int b){
            return a + b;
        }
    }
    class program{
        static void Main(string[] args){
            var add1 = new addition();
            var add2 = new addition();
           var result = add1.add(1, 4);
           Console.WriteLine(add2.add(2, 4));
            Console.WriteLine(result); 
        }
    }
}