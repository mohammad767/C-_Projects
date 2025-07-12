Console.Write("Enter the number to check : ");
int inputNumber = int.Parse(Console.ReadLine());
int i = 2;

while (i<10)
{
    if (inputNumber != i)
    {
        if (inputNumber % i == 0)
        {
            Console.WriteLine($"{inputNumber} is not a prime number");
            break;
        }

        if (i == 9)
        {
            Console.WriteLine($"{inputNumber} is a prime number");
            break;
        }
    }
    i++;
}