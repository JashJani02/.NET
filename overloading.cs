using System;

public class Number
{
    public int value;

    // Default constructor
    public Number() { }

    // Parameterized constructor 
    public Number(int n)
    {
        value = n;
    }

    // Overloaded '+' operator 
    public static Number operator +(Number a, Number b)
    {
        Number c = new Number();
        c.value = a.value + b.value;
        return c;
    }



    public static void Main(string[] args)
    {
        Number a = new Number(10);
        Number b = new Number(20);
        Number c = a + b;

        Console.WriteLine(c.value); // Outputs 30
    }
}