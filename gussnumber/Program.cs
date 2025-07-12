Random rdn = new Random();
int number = rdn.Next(1,101);
Console.WriteLine(number);

while (true)
{
    Console.Write("Guss the number : ");
    int inputNUmber = int.Parse(Console.ReadLine());
    if (number > inputNUmber)
    {
        Console.WriteLine("The number is greater than the current number");
    }
    else if (number < inputNUmber)
    {
        Console.WriteLine("The number is less than the current number");
    }
    else
    {
        Console.WriteLine("Crroct");
        break;
    }
    
}