using System;

class Program
{
    static void Main(string[] args)
    {
        //This will call on the originals which should pull 1/1 because it is the base value of _top and _bottom
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        //This will call on _top being values at 5 and _bottom being at 1. This will mean it should return 5/1 and the decimal of 5.
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        //The _top value is set to 3 and the _bottom value is set to 4. This should send back 3/4 for the Fraction String and .75 for the decimal        
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        //The _top value is set to 1 and the _bottom value is set to 3. This should return back 1/3 for the Fraction String and .33 repeating for the decimal.
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}