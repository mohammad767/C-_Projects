static int GetInputNumber()
{ 
    Console.Write("Enter the factoriel number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

static int CalculateFactoriel(int number)
{
    int tmp = 1;
    for (int i = 1; i <= number; i++)
    {
        tmp = tmp * i;
    }
    return tmp;
}
int number = GetInputNumber();
int result = CalculateFactoriel(number);
Console.WriteLine(result);