// this is two parmetr calc
while (true)
{
    Console.WriteLine("a --> add");
    Console.WriteLine("m --> mines");
    Console.WriteLine("mu --> multiply");
    Console.WriteLine("d --> divide");
    Console.WriteLine("e --> exit");
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine()!;
    if (choice == "e")
    {
        Console.WriteLine("goodbye");
        break;
    }
    Console.Write("Enter your first number: ");
    float firstNumber = float.Parse(Console.ReadLine()!);
    Console.Write("Enter your second number: ");
    float secondNumber = float.Parse(Console.ReadLine()!);
    switch (choice)
    {
        case "a":
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            break;
        case "m":
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            break;
        case "mu":
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            break;
        case "d":
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}
