using System;

namespace CombinedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to choose which program to run
            Console.WriteLine("Choose a program to run (1 or 2):\n1. GreatestCommonDivisor\n2. Fractions");
            string choice = Console.ReadLine();

            // Run the GreatestCommonDivisor program
            if (choice == "1")
            {
                Console.WriteLine("GreatestCommonDivisor (164, 410) = " + GreatestCommonDivisor(164, 410));
                Console.WriteLine("GreatestCommonDivisor (87801, 1469) = " + GreatestCommonDivisor(87801, 1469));
            }
            // Run the Fractions program
            else if (choice == "2")
            {
                // Create and display a fraction
                Fraction f1 = new Fraction(1, 2);
                Console.WriteLine("1/2 = " + f1.ToDecimal());

                // Add two fractions and display the result
                Fraction f2 = new Fraction(1, 7);
                Fraction f3 = new Fraction(1, 5);
                Console.WriteLine("1/7 + 1/5 = " + f2.Add(f3));

                // Multiply three fractions and display the result
                Fraction f4 = new Fraction(1, 4);
                Fraction f5 = new Fraction(2, 3);
                Fraction f6 = new Fraction(4, 5);
                Console.WriteLine("1/4 * 2/3 * 4/5 = " + f4.Multiply(f5).Multiply(f6));
            }
        }

        // Method to find the greatest common divisor using Euclid's algorithm
        static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Fraction class definition
        class Fraction
        {
            // Properties for numerator and denominator
            public int Numerator { get; set; }
            public int Denominator { get; set; }

            // Constructor to initialize a new Fraction object
            public Fraction(int numerator, int denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
            }

            // Method to convert the fraction to a decimal
            public double ToDecimal()
            {
                return (double)Numerator / Denominator;
            }

            // Method to add two fractions
            public Fraction Add(Fraction f)
            {
                int newNumerator = Numerator * f.Denominator + f.Numerator * Denominator;
                int newDenominator = Denominator * f.Denominator;
                return new Fraction(newNumerator, newDenominator).Simplify();
            }

            // Method to multiply two fractions
            public Fraction Multiply(Fraction f)
            {
                int newNumerator = Numerator * f.Numerator;
                int newDenominator = Denominator * f.Denominator;
                return new Fraction(newNumerator, newDenominator).Simplify();
            }

            // Method to simplify a fraction
            public Fraction Simplify()
            {
                int gcd = GreatestCommonDivisor(Numerator, Denominator);
                return new Fraction(Numerator / gcd, Denominator / gcd);
            }

            // Method to display the fraction as a string
            public override string ToString()
            {
                return Numerator + "/" + Denominator;
            }
        }
    }
}