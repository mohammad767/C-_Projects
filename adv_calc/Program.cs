using System.Threading.Channels;

static float GetNumber(string messege)
{
    Console.WriteLine(messege);
    try
    {
        Console.Write("Enter a number: ");
        return float.Parse(Console.ReadLine()!);
    }
    catch (Exception)
    {
        Console.WriteLine("You have entered an incorrect format!");
        return GetNumber(messege);
    }
}

static string GetOperation()
{
    Console.WriteLine("Enter opertion :  +,-,*,/,=");
    string op = Console.ReadLine()!;
    if (op == "+" || op == "-" || op == "*" || op == "/" || op == "=")
    {
        return op; 
    }
    Console.Write("You have entered an incorrect operation!");
    return GetOperation();
}

static float Calcultor(float numberone,float numbertwo,string op)
{
    switch (op)
    {
        case "+":
            return numberone + numbertwo;

        case "-":
            return numberone - numbertwo;

        case "*":
            return numberone * numbertwo;

        case "/":
            if (numbertwo == 0)
            {
                Console.WriteLine("Can't divide by 0");
                return 0;
            }
           return numberone / numbertwo;
        default:
            Console.WriteLine("Invalid Operation");
            return 0;
    }
}

float numberone = GetNumber("0");
string tmp = $"{numberone}";
while (true)
{
    
    string op = GetOperation();
    if (op == "=")
    {
        break;
    }
    float numbertwo = GetNumber("");
    float result = Calcultor(numberone, numbertwo, op);
    Console.Clear();
    tmp += $"{op}{numbertwo}";
    Console.WriteLine(tmp);
    Console.WriteLine(result);
    numberone = result;
   
}



//
//Console.Clear();
//Console.WriteLine($"{numberone} {op} {numbertwo} = {result}");

//while (op != "=")
//{
//  Console.WriteLine("If you want End Enter =");
//    op = GetOperation();
//  float number = GetNumber("Enter number : ");
//    float result2 = Calcultor(number, result, op);
//    Console.WriteLine($"{number} {op} {result} = {result2}");
    
//}
