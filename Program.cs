using System;

namespace VariablesCS
{

    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 1;
            var fullName = "Austin Pierce";
            var today = DateTime.Now;
            Console.WriteLine(" " + fullName + " drinks " + numberOfCupsOfCoffee + " cup of coffee each day " + " and today is " + today + ".");


            Console.Write("What's your name? ");
            var userName = Console.ReadLine();
            Console.Write("Good Afternoon" + userName + ", how is your day today?");

            Console.WriteLine("Can you please input two numbers");
            Console.Write("Give me your first number");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("Give me your second number");
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine("Choose a first number");
            var firstOperand = Double.Parse(Console.ReadLine());
            Console.WriteLine("Choose a second number");
            var secondOperand = Double.Parse(Console.ReadLine());

            var sum = firstOperand + secondOperand;
            Console.WriteLine("The total of the sum is = to " + sum);
            var difference = secondOperand - firstOperand;
            Console.WriteLine("The total of the difference is = to " + difference);
            var product = firstOperand * secondOperand;
            Console.WriteLine("The total of the product is = to " + product);
            var quotient = firstOperand / secondOperand;
            Console.WriteLine("The total of the quotient is = to " + quotient);
            var remainder = firstOperand % secondOperand;
            Console.WriteLine("The total of the remainder is = to " + remainder);

            Console.WriteLine("If you add 5 and 4 your sum is 9");
            Console.WriteLine("If you subtract 10 and 4 your difference is 6");
            Console.WriteLine("If you multiply 5 and 4 your product is 9");
            Console.WriteLine("If you divide 10 and 2 your quotient is 5");
            Console.WriteLine("If you find the remainder of 12 and 13 your total is .923076");





        }
    }
}
