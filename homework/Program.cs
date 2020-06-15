using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Результат деления: {Division()}");

        }

        static int Division()
        {
            int result = 0;

            int firstNumber, secondNumber;
            string input;
            Console.WriteLine("Enter first number: ");
            input = Console.ReadLine();
            firstNumber = int.Parse(input);

            Console.WriteLine("Enter second number: ");
            input = Console.ReadLine();
            secondNumber = int.Parse(input);

            /*if (secondNumber == 0)
            {
                throw new ArgumentException("Нельзя делить на ноль");
            }*/

            try
            {
                result = firstNumber / secondNumber;
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Результат будет равен 0");
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Результат будет равен 0");
            }
            /*catch (ArgumentException exception) when (secondNumber == 0)
            {
                Console.WriteLine(exception.GetType().Name);
                Console.WriteLine(exception.Message);
                Console.WriteLine("Результат будет равен 0");
            }*/

            return result;
        }
    }
}
