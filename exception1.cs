using System;

public static class exception1
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("enter number_1: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number_2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Cast 'num' to float so C# performs floating-point division
            float result = (float)num / num2;

            // Fixed the format specifier to F2 for two decimal places
            Console.WriteLine($"RESULT: {result:F2}");

            Console.WriteLine("code ran without any exceptions");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("exception divide by zero intercepted");
        }
        finally
        {
            Console.WriteLine("try-catch-finally block executed successfully");
        }
    }
}
