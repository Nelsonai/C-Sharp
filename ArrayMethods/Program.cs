namespace Name
{
    class program{
        static void Main(string[] args)
        {
            //! Length 
            var number = new[]{7,15,4,67,9,2,23,90};
            Console.WriteLine("Length is: " + number.Length);

            //! IndexOf()
            var index = Array.IndexOf(number, 4);
            Console.WriteLine("Index of 4 is: "+ index);

            Console.WriteLine("..........Clear");
            //! Clear()
            Array.Clear(number,0, 2);
            foreach(var i in number){
                Console.WriteLine(i);
            }
            Console.WriteLine("...........Copy");
            
            //! Copy()
            var num = new int[3];
            Array.Copy(number, num, 3);
            foreach(var n in num){
                Console.WriteLine(n);
            }
            Console.WriteLine(".............Sort");
            //! Sort()
            Array.Sort(number);
            foreach (var s in number)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("...............Reverse");
            //! Reverse()
            Array.Reverse(number);
            foreach(var r in number)
            {
                Console.WriteLine(r);
            }
        }
    }
}