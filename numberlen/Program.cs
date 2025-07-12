Console.Write("Enter a number: ");
int inputNumber = int.Parse(Console.ReadLine()!);
int i = 0;
while (inputNumber > 0)
{
    inputNumber = inputNumber / 10;
    i++;
}

Console.WriteLine($"your input number lenght: {i}");