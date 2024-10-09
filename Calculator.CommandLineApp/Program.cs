using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using CalcLib = Calculator.ClassLibrary;
namespace Calculator.CommandLineApp;

internal class Program
{
    static void Main(string[] args)
    {
        ValidateAndCalculate(args);
    }

    private static void ValidateAndCalculate(string[] args)
    {
        if (!ValidateArguments(args))
        {
            ShowInstructions();
            return;

        }

        ProcessCalculation(args);

    }
    

    private static void ProcessCalculation(string[] args)
    {
        try
        {
            float number1 = ParseArgument(args[0]);
            float number2 = ParseArgument(args[2]);
            string operation = args[1];

            var _calculator = new CalcLib.CalculatorLogic();
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

    private static float PerformOperation(CalcLib.CalculatorLogic calculator, float number1, float number2, string operation)
    {
        return operation switch
        {
            "+" => calculator.Add(number1, number2),
            "-" => calculator.Subtract(number1, number2),
            "*" => calculator.Multiply(number1, number2),
            "/" => calculator.Divide(number1, number2),
            _ => throw new InvalidOperationException($"Invalid operator '{operation}'. Please use: +, -, *, /"),
        };
    }


}

//Noter til Solution
//Error handling hvis noget ikke kan parses som float?
//Single responsibility  - entry metoden er nemt at forstå, men gør flere ting.