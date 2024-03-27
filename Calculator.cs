using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
    static void ExtraMain(string[] args)
    {
        int num1;
        int num2;

        String answer;
        int result = 0;


        Console.WriteLine("Hello, welcome to this calculator app");
        Console.WriteLine("Enter your first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        System.Console.WriteLine("Enter the second number");
        num2 = Convert.ToInt32(Console.ReadLine());


        System.Console.WriteLine("what type of operation would you like to do:");
        System.Console.WriteLine("Enter a for addition, s for subtraction, d for division, m for multiplication");
        answer = Console.ReadLine();

        if (answer == "a") 
        {
            result = num1 + num2;
        }
        else if (answer == "s")
        {
            result = num1 - num2;
        }
        else if (answer == "d")
        {
            if (num2 != 0)
            {
                result = num1 /num2;
            }
            else 
            {
               Console.WriteLine("Cannot divide by 0");
            }
            
        }
        else if (answer == "m")
        {
            result = num1 * num2;
        }
        else
        {
            System.Console.WriteLine("Please run again, press a,s,m, or d");
        }

        System.Console.WriteLine("The result is: " + result);
        System.Console.WriteLine("THank you for using this");



        Console.ReadKey();

    }
    }
}