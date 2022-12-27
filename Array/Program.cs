namespace MyNamespace
{
    class program{
        public static void Main(string[] args)
        {
            // int[] numbers = new int[3]; or
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]); 

            var names = new string[3] {"Kachi","Victor","Mary"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            // STRING FORMATTING
            // STRING LITERALS
            var firstName = "Nelson-AI";
            var lastName = "Kc-Neil";
            // 1.-
            var fullName = firstName + " " + lastName;
            // 2.
            string name = string.Format("My name is {0}  {1}", firstName, lastName);
            Console.WriteLine(name);
            // COMBINING ITEMS IN A LIST
            var randomNames = new string[3] {"Ezekiel","micheal","odegard"};
            var formattedNames = string.Join(",", randomNames);
            Console.WriteLine(formattedNames);
        }
    }
}