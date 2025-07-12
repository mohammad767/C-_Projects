Console.Write("Enter your charge : ");
int charge = int.Parse(Console.ReadLine());

if (charge == 100)
{
    Console.Write("Full");
}

else if (charge <= 99 && charge > 80)
{
    Console.WriteLine("Well");
}

else if (charge <= 80 && charge > 50)
{
    Console.WriteLine("Good");
}

else if (charge == 50)
{
    Console.WriteLine("Half");
}

else if (charge < 50 && charge > 25)
{
    Console.WriteLine("Fine");
}

else if (charge < 25)
{
    Console.WriteLine("Low battry");
}

else
{
    Console.WriteLine("Unknown");
}