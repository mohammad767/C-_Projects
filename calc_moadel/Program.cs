static float GetInputNumber()
{
    Console.WriteLine("Enter 00 to exit");
    Console.Write("Enter the Score :");
    try
    {
        float number = Convert.ToInt32(Console.ReadLine());
        if (number == 00)
        {
            return 00;
        }
        return number;
    }
    catch (Exception)
    {
        Console.WriteLine("Incorrect input");
        return GetInputNumber();
    }
}

static List<float> Addtolist()
{
    List<float> scoers = new List<float>();
    while (true)
    {
        float scoer = GetInputNumber();
        if (scoer == 00)
        {
           return scoers;
        }
        else
        {
            scoers.Add(scoer);
        }
    }
}

static float Calculatavreg(List<float> scorelist)
{
    float tmp = 0;
    foreach (float score in scorelist)
    {
        tmp += score;
    }
    return tmp / scorelist.Count;
}

List<float> list =Addtolist();
float average = Calculatavreg(list);
Console.Clear();
Console.WriteLine($"Average Score: {average}");