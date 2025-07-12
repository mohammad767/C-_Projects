Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
int sumNumber = 0;
while (number > 0)
{
    int number2 = number % 10;
    sumNumber = sumNumber + number2;
    number = number / 10;
    
}

Console.WriteLine(sumNumber);
