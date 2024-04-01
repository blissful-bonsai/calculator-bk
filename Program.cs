float finalResult = 0;

bool useResult()
{
    if (finalResult != 0)
    {
        Console.WriteLine("Would you like to use the value from the last operation as a value for the operation? 'yes' - Yes");
        string userChoice = Console.ReadLine();
        if (userChoice == "yes")
        {
            return true;
        }
    }
    return false;
}

float addNumbers(float numberOne, float numberTwo)
{
    if (useResult())
    {
        float result = finalResult + numberTwo;
        finalResult = result;
        return result;
    }
    else
    {
        float result = numberOne + numberTwo;
        finalResult = result;
        return result;
    }
    
}

float subtractNumbers(float numberOne, float numberTwo)
{
    float result = numberOne + numberTwo;
    finalResult = result;
    return result;
}

float multiplyNumbers(float numberOne, float numberTwo)
{
    float result = numberOne + numberTwo;
    finalResult = result;
    return result;
}

float divideNumbers(float numberOne, float numberTwo)
{
    float result = numberOne + numberTwo;
    finalResult = result;
    return result;
}

bool sameOperation()
{
    Console.WriteLine("Would you like to perform the same operation?");
    string userChoice = Console.ReadLine();
    if(userChoice == "yes")
    {
        return true;
    }
    else
    {
        return false;
    }
}



string userChoice = "";

while(userChoice != "exit")
{
    Console.WriteLine("Specify an operation:");
    Console.WriteLine("'exit' - Exit\n'add' - Add\n'subtract' - Subtract\n'multiply' - Multiply\n'divide' - Divide\n");
    userChoice = Console.ReadLine();

    switch(userChoice)
    {
        case "add":

            do
            {
                Console.WriteLine("Insert the values for the numbers, insert a value, press enter, then insert another value and press enter");
                float firstNumber = float.Parse(Console.ReadLine());
                float secondNumber = float.Parse(Console.ReadLine());
                addNumbers(firstNumber, secondNumber);
                Console.WriteLine("The result is: " + finalResult + "\n");
            } while (sameOperation());
            
            break;
            
    }
}




