decimal finalResult = 0;

bool useResult()
{
    if (finalResult != 0)
    {
        Console.WriteLine("Would you like to use the value from the last operation as a value for the operation? 'yes' - Yes, 'no' - No");
        string userChoice = Console.ReadLine();
        if (userChoice == "yes")
        {
            return true;
        }
    }
    return false;
}


bool sameOperation()
{
    Console.WriteLine("Would you like to perform the same operation?");
    string userChoice = Console.ReadLine();
    if (userChoice == "yes")
    {
        return true;
    }
    else
    {
        return false;
    }
}


decimal addNumbers(decimal numberOne, decimal numberTwo)
{
    if (useResult())
    {
        decimal result = finalResult + numberTwo;
        finalResult = result;
        return result;
    }
    else
    {
        decimal result = numberOne + numberTwo;
        finalResult = result;
        return result;
    }
    
}

decimal subtractNumbers(decimal numberOne, decimal numberTwo)
{
    if (useResult())
    {
        decimal result = finalResult - numberTwo;
        finalResult = result;
        return result;
    }
    else
    {
        decimal result = numberOne - numberTwo;
        finalResult = result;
        return result;
    }
    
}

decimal multiplyNumbers(decimal numberOne, decimal numberTwo)
{
    if (useResult())
    {
        decimal result = finalResult * numberTwo;
        finalResult = result;
        return result;
    }
    else
    {
        decimal result = numberOne * numberTwo;
        finalResult = result;
        return result;
    }
        
}

decimal divideNumbers(decimal numberOne, decimal numberTwo)
{
    if (useResult())
    {
        decimal result = finalResult / numberTwo;
        finalResult = result;
        return result;
    }
    else
    {
        decimal result = numberOne / numberTwo;
        finalResult = result;
        return result;
    }
}




string userChoice = "";

while(userChoice != "exit")
{
    Console.WriteLine("Specify an operation:");
    Console.WriteLine("'exit' - Exit\n'add' - Add\n'subtract' - Subtract\n'multiply' - Multiply\n'divide' - Divide\n");
    Console.WriteLine("\n\n Please remember, use commas instead of dots on every operation!\n\n");
    userChoice = Console.ReadLine();
    while(userChoice != "add" && userChoice != "subtract" && userChoice != "multiply" && userChoice != "divide" && userChoice != "exit")
    {
        Console.WriteLine("Specify a valid operation");
        userChoice = Console.ReadLine();
    }
    switch (userChoice)
    {
        case "add":

            do
            {
                Console.WriteLine("Insert the values for the numbers, insert a value, press enter, then insert another value and press enter");
                decimal firstNumber = decimal.Parse(Console.ReadLine());
                decimal secondNumber = decimal.Parse(Console.ReadLine());
                addNumbers(firstNumber, secondNumber);
                Console.WriteLine("The result is: " + finalResult.ToString("0.00") + "\n");
            } while (sameOperation());
            
            break;

        case "subtract":
            do
            {
                Console.WriteLine("Insert the values for the numbers, insert a value, press enter, then insert another value and press enter");
                decimal firstNumber = decimal.Parse(Console.ReadLine());
                decimal secondNumber = decimal.Parse(Console.ReadLine());
                subtractNumbers(firstNumber, secondNumber);
                Console.WriteLine("The result is: " + finalResult.ToString("0.00") + "\n");
            } while (sameOperation());
            break;

        case "multiply":
            do
            {
                Console.WriteLine("Insert the values for the numbers, insert a value, press enter, then insert another value and press enter");
                decimal firstNumber = decimal.Parse(Console.ReadLine());
                decimal secondNumber = decimal.Parse(Console.ReadLine());
                multiplyNumbers(firstNumber, secondNumber);
                Console.WriteLine("The result is: " + finalResult.ToString("0.00") + "\n");
            } while (sameOperation());
            break;

        case "divide":
            do
            {
                Console.WriteLine("Insert the values for the numbers, insert a value, press enter, then insert another value and press enter");
                decimal firstNumber = decimal.Parse(Console.ReadLine());
                decimal secondNumber = decimal.Parse(Console.ReadLine());
                while (firstNumber == 0 || secondNumber == 0)
                {
                    Console.WriteLine("None of the numbers can be zero, please insert a number that is not zero: ");
                    firstNumber = decimal.Parse(Console.ReadLine());
                    secondNumber = decimal.Parse(Console.ReadLine());
                }
                divideNumbers(firstNumber, secondNumber);
                Console.WriteLine("The result is: " + finalResult.ToString("0.00") + "\n");
            } while (sameOperation());
            break;


    }
}




