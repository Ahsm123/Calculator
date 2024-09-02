using System;
using System.Security.Cryptography.X509Certificates;
using CalcLib = Calculator.ClassLibrary;
namespace Calculator.CommandLineApp;

internal class Program
{
    static void Main(string[] args)
    {
        //Test funktionalitet
        //Console.WriteLine("Testing Calculator Operations:");
        //Console.WriteLine($"Addition of 5 and 25: {_calculator.Add(5, 25)}");
        //Console.WriteLine($"Subtraction of 25 from 5: {_calculator.Subtract(5, 25)}");
        //Console.WriteLine($"Multiplication of 5 and 25: {_calculator.Multiply(5, 25)}");
        //Console.WriteLine($"Division of 25 by 5: {_calculator.Divide(25, 5)}");

        //Inspicer antallet af argumenter
 
        if (!ValidateArguments(args))
        {
            ShowInstructions();
            return;

        }

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Arguments {i + 1}: {args[i]}");
        }

        try
        {
            float number1 = ParseArgument(args[0]);
            float number2 = ParseArgument(args[2]);
            string operation = args[1];

            var _calculator = new CalcLib.Calculator();
            float result = PerformOperation(_calculator, number1, number2, operation);

            Console.WriteLine($"Result of {number1} {operation} {number2} = {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error parsing numbers: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occured: {ex.Message}");
        }
    }

    private static bool ValidateArguments(string[] args)
    {
        return args.Length == 3;
    }

    private static void ShowInstructions()
    {
        Console.WriteLine("Please provide 3 arguments in the format [number1] [operation] [number2]");
        Console.WriteLine("Example: .\\Calculator.CommandLineApp.exe 5 + 30");
    }

    private static float ParseArgument(string argument)
    {
        return float.Parse(argument);
    }

    private static float PerformOperation(CalcLib.Calculator _calculator, float number1, float number2, string operation)
    {
        return operation switch
        {
            "+" => _calculator.Add(number1, number2),
            "-" => _calculator.Subtract(number1, number2),
            "*" => _calculator.Multiply(number1, number2),
            "/" => _calculator.Divide(number1, number2),
            _ => throw new InvalidOperationException($"Invalid operator '{operation}'. Please use: +, -, *, /"),
        };
    }


}
