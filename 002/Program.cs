Console.WriteLine("Write Your number");
int number = Convert.ToInt32(Console.ReadLine());
int a = DigCount(number);
Console.WriteLine($"{a}");
int DigCount(int num)
{
    num = Math.Abs(num);
    int count = 0;
    while (num >= 1)
    {
        num = num / 10;
        count++;
    }
    return count;
}