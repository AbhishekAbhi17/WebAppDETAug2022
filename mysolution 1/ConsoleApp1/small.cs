using System;

public class small
{
    public static void Main()
    {
        int num1, num2;
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number : ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 <num2)
        {
            Console.Write($"the small value is{num1}");
        }
        else
        {
            Console.Write($"the small value is{num2}");
        }
        

    }
        
        
}
