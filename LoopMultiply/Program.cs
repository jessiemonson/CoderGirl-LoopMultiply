using System;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            int runningTotal = 0;
            int userValue = 0;
            Console.Write("Enter a number: ");
            userValue = int.Parse(Console.ReadLine());
            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 
            for (int i = 2; i <= 20; i++)
            {
                Console.WriteLine(i * userValue);
                runningTotal += i * userValue;
            }
            // TODO: When the loop is finished, output the sum of all previous values.
            Console.WriteLine(runningTotal);
            Console.ReadLine();
        }
    }
}
