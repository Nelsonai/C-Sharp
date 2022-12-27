// namespace Name
// {
//     class program{
//         static void Main(string[] args)
//         {
//             int hour = 10;
//             if(hour>0 && hour < 12){
//                 Console.WriteLine("It's morning");
//             }    
//             else if(hour>12 && hour<18){
//                 Console.WriteLine("It's afternoon");
//             }
//             else if(hour>18 && hour < 23){
//                 Console.WriteLine("It's evening");
//             }
//             else{
//                 Console.WriteLine("It's night Time");                                                           
//             }       
//         }
//     }
// }
// ..................................................................................
// ..................................................................................

namespace Name
{
    // CONDITIONAL OPERATORS
    class program{
        public static void Main(string[] args)
        {
            // bool isGoldCUstomer = true;
            // float price;
            // NORMAL WAY OF WRITING IF STATEMENTS
            // if(isGoldCUstomer){
            //     price = 100f;
            // }
            // else{
            //     price = 200f;
            // }    
            // USING CONDITIONAL OPERATORS
            // price = (isGoldCUstomer) ? 100f : 200f;
            // Console.WriteLine(price);

            Console.WriteLine("................................");
            Console.WriteLine("................................");

            Console.Write("what day is it: ");
            var day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("it's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Saturday");
                    break;
                default:
                    Console.WriteLine(day + " is not a day");
                    break;
            }
        }
    }
}