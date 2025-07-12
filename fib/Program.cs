int firstNumber = 0;
int secondNumber = 1;
Console.Write("How long you want to do?: ");
int step = int.Parse(Console.ReadLine()!);
if (step >= 1)
{
    Console.WriteLine(firstNumber);
}

if (step >= 2)
{
    Console.WriteLine(secondNumber);
}
for (int i = 1; i <= step; i++)
{
    int thirdNumber = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = thirdNumber;
    Console.WriteLine(thirdNumber);
}