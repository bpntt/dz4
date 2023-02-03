int Parse(int number)
{
    if (number == 0) return 0;
    int result = number % 2;
    number /= 2;
    result += Parse(number) * 10;
    return result;
}
Console.WriteLine("write your number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Parse(number));