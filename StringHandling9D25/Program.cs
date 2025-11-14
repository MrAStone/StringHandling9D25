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

            // character at index of string
            Console.WriteLine(input[0]);//first character
            Console.WriteLine(input[input.Length-1]);//last character

            // find index of character
            Console.WriteLine(input.IndexOf('A')); //outputs index of first A (-1 if not there)
            Console.WriteLine(input.IndexOf("ell"));

            // substring
            Console.WriteLine(input.Substring(input.Length-3)); // outputs last 3 characters
            Console.WriteLine(input.Substring(5,4));//outputs 4 characters starting at index 5

        }
    }
}
