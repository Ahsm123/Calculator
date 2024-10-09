using CalcLib = Calculator.ClassLibrary;

internal static class ProgramHelpers
{


    private static void ProcessCalculation(string[] args)
    {
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
}