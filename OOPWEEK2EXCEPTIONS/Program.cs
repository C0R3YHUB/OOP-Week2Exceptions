CalculatorApp();

void CalculatorApp()
{
    try
    {



        Console.WriteLine("Please enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Please enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please select a function: +, -, /, * ");
        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;


        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            default:
                Console.WriteLine("Invalid Operation.");
                return;


        }

        Console.WriteLine($"Result: {result}");

    }
    catch (FormatException ex)
    {
        Console.WriteLine("");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"You cannot divide by 0.");
    }
    finally
    {

    }
}

