using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fraction1 = new Fraction();
        // Console.WriteLine(fraction1.FractionString(true));
        // fraction1.SetTop(4);
        // fraction1.SetBottom(4);
        // Console.WriteLine(fraction1.FractionString(true));
        // Console.WriteLine(fraction1.FractionString(false));


        // Fraction fraction2 = new Fraction(5);
        // Console.WriteLine(fraction2.FractionString(true));
        // fraction2.SetTop(12);
        // fraction2.SetBottom(2);
        // Console.WriteLine(fraction2.FractionString(true));
        // Console.WriteLine(fraction2.FractionString(false));


        // Fraction fraction3 = new Fraction(6, 7);
        // Console.WriteLine(fraction3.FractionString(true));
        // fraction3.SetTop(9);
        // fraction3.SetBottom(11);
        // Console.WriteLine(fraction3.FractionString(true));

    // Step 6
        // Fraction fraction4 = new Fraction(3, 4);
        // Console.WriteLine(fraction4.FractionString(true));
        // double decimal4 = fraction4.DecimalValue();
        // Console.WriteLine(decimal4);
        // fraction4.SetTop(1);
        // fraction4.SetBottom(3);
        // Console.WriteLine(fraction4.FractionString(true));
        // double decimal5 = fraction4.DecimalValue();
        // Console.WriteLine(decimal5);

        Fraction fraction5 = new Fraction();
        Random randomNum = new Random();
        int top;
        int bottom;
        for (int i = 1; i < 21; i++)
        {
            top = randomNum.Next(1, 20);
            bottom = randomNum.Next(1, 20);
            fraction5.SetTop(top);
            fraction5.SetBottom(bottom);
            double decimal6 = fraction5.DecimalValue();
            Console.WriteLine(
                $"Fraction {i}: string: {fraction5.FractionString(true)} " +
                $"Number: {decimal6:F2}"
                );
        }
    }
}