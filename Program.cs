namespace ASSIGNMENT_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment 1_2";
            Console.WriteLine("This program checks if two numbers are equal, please enter two numbers and press enter after each one");

            double numOne = Convert.ToDouble(Console.ReadLine());
            double numTwo = Convert.ToDouble(Console.ReadLine());

            if (numOne == numTwo)
            {
                Console.WriteLine("These numbers are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are not equal");
            }
            Console.Read();
        }
    }
}
    

