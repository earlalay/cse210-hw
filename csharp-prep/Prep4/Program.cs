using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int currentNumber = -1;
        while (currentNumber != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            currentNumber = int.Parse(userNumber);
            if (currentNumber != 0)
            {
                numbers.Add(currentNumber);
            }
        }
        
        int numberTotal = 0;
        int largestNumber = 1;
        foreach (int number in numbers)
        {
            numberTotal += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        double numberAverage = (double)numberTotal / numbers.Count;
        Console.WriteLine($"The sum is: {numberTotal}");
        Console.WriteLine($"The average is: {numberAverage}");
        Console.Write($"The largest number is: {largestNumber}");
    }
}