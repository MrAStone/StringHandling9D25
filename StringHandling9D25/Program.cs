namespace StringHandling9D25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a string variable called input
            string input;
            // ask the user to enter a value
            Console.Write("Enter something: ");
            // store the input in the variable input
            input =Console.ReadLine();
            // output the value to the console
            Console.WriteLine(input);
            // find the length of the string
            Console.WriteLine(input.Length);
            int stringLength = input.Length;
            Console.WriteLine(stringLength);
        }
    }
}
