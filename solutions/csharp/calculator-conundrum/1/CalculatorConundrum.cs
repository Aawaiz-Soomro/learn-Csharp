using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        try {
        switch (operation)
        {
            case "/":
                if (operand2 != 0)
                    return $"{operand1} / {operand2} = {SimpleOperation.Division(operand1,                                         operand2)}";
                else
                    throw new DivideByZeroException();
            case "*":
                return $"{operand1} * {operand2} = {SimpleOperation.Multiplication(operand1,                                         operand2)}";
            case "+":
                return $"{operand1} + {operand2} = {SimpleOperation.Addition(operand1,                                         operand2)}";
            default:
                if (operation == null)
                    throw new ArgumentNullException();
                else if (operation == "" )
                    throw new ArgumentException();
                else
                    throw new ArgumentOutOfRangeException();
        }
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }

    }
}
