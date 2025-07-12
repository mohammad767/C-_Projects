static float GetInputNumber(string message)
{ 
    Console.Write(message);
    float number = Convert.ToInt32(Console.ReadLine());
    return number;
}

static float CheckNumber(float number1, float number2, float number3)
{
    float result = number1;
    if (number2 > result)
    {
        result = number2;
    }

    if (number3 > result)
    {
        result = number3;
    } 
    return result;

}
float number1 = GetInputNumber("Enter the first number: ");
float number2 = GetInputNumber("Enter the first number: ");
float number3 = GetInputNumber("Enter the first number: ");
float result = CheckNumber(number1, number2, number3);
Console.WriteLine($"the biggest number is {result}");