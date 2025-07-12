static float GetInputNumber()
{
    Console.Write("Enter number: ");
    return float.Parse(Console.ReadLine());
}

static bool CheckOdd(float number)
{
    return number % 2 == 0;
}
var number = GetInputNumber();

if (CheckOdd(number))
{
    Console.WriteLine("Odd");
}
else
{
    Console.WriteLine("Even");
}