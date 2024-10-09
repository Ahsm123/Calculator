namespace Calculator.ClassLibrary;

public class CalculatorLogic
{
    public float Add(float firstNumber, float secondNumber) => firstNumber + secondNumber;
    public float Subtract(float firstNumber, float secondNumber) => firstNumber - secondNumber;
    public float Divide(float firstNumber, float secondNumber) => firstNumber / secondNumber;
    public float Multiply(float firstNumber, float secondNumber) => firstNumber * secondNumber;

}

// Kunne være statisk hvis den ikke skal gemme på en state, men det ville fx ikke være muligt at lave dependency injection til test.