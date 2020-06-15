using System;

namespace homework_2task
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE_OF_ARRAY = 10;
            int[] arrayOfNumbers = new int[SIZE_OF_ARRAY];
            Random rand = new Random();

            for (int i = 0; i < SIZE_OF_ARRAY; i++)
            {
                arrayOfNumbers[i] = rand.Next() % 20;
            }

            try
            {
                for (int i = 0; i <= SIZE_OF_ARRAY; i++)
                {
                    Console.Write($"{arrayOfNumbers[i]}");
                    Console.Write(" ");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine();
                Console.WriteLine(exception.Message);
            }
        }
    }
}
