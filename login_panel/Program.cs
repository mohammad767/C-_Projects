using System.Text.RegularExpressions;

static string UserInput(string messeg)
{
    Console.Write(messeg);
    return Console.ReadLine()!;
}

static string EmailCheck(string email)
{
    string pattern = @"^[\w\.-]+@[\w\.-]+\.\w{2,}$";
    
    if (Regex.IsMatch(email, pattern))
    {
        return email;
    }

    return "";
}

static string PasswordCheck(string password)
{
    string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).{8,}$";
    if (Regex.IsMatch(password, pattern))
    {
        return password;
    }

    return "";
}

int attempts = 0;
while (attempts < 5)
{
    Console.WriteLine(attempts);
    string email = UserInput("Enter your email: ");
    string password = UserInput("Enter password: ");

    if (EmailCheck(email) == "" && PasswordCheck(password) == "")
    {
        Console.WriteLine("Please enter your email and password correct");
        attempts++;
    }
    else if (EmailCheck(email) == "")
    {
        Console.WriteLine("Please enter your email correct");
        attempts++;
    }
    else if (PasswordCheck(password) == "")
    {
        Console.WriteLine("Please enter your password correct");
        attempts++;
    }

    else
    {
        Console.WriteLine($"Welcome {email}");
        break;
    }

    if (attempts == 5)
    {
        Console.WriteLine("To many wrong try");
        Thread.Sleep(60000);
        attempts = 0;
    }
}