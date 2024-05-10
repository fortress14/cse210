using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction fc1 = new Fraction(1);
       Console.WriteLine(fc1.GetFractionString());
       Console.WriteLine(fc1.GetDecimalValue());

       Fraction fc2 = new Fraction(5);
       Console.WriteLine(fc2.GetFractionString());
       Console.WriteLine(fc2.GetDecimalValue());

       Fraction fc3 = new Fraction(3,4);
       Console.WriteLine(fc3.GetFractionString());
       Console.WriteLine(fc3.GetDecimalValue());

       Fraction fc4 = new Fraction(1,3);
       Console.WriteLine(fc4.GetFractionString());
       Console.WriteLine(fc4.GetDecimalValue());

    }
}