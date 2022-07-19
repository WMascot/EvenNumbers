void IsEven_First(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Четное");
        return;
    }
    Console.WriteLine("Не четное");
}

void IsEven_Second(int number)
{
    if ((number / 2) * 2 == number)
    {
        Console.WriteLine("Четное");
        return;
    }
    Console.WriteLine("Не четное");
}

void IsEven_Third(int number)
{
    if ((number & 1) == 0)
    {
        Console.WriteLine("Четное");
        return;
    }
    Console.WriteLine("Не четное");
}

void IsEven_Fourth(int number)
{
    if ((number >> 1) << 1 == number)
    {
        Console.WriteLine("Четное");
        return;
    }
    Console.WriteLine("Не четное");
}

IsEven_First(5);
IsEven_First(4);
IsEven_Second(5);
IsEven_Second(4);
IsEven_Third(5);
IsEven_Third(4);
IsEven_Fourth(5);
IsEven_Fourth(4);