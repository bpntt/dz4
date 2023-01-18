Console.WriteLine("Write Your number");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0)
{
    Console.WriteLine("Number can noy be less than 0");
    return;
}


int lenght = Lenght1(a);
int Lenght1(int y)
{
    int index = 0;
    while (y > 0)
    {
        y /= 10;
        index++;
    }
    return index;
}
int Total = Sum1(a, lenght); 
int Sum1(int a, int lenght)
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
    
}
Console.WriteLine($"сумма цифр {Total}");