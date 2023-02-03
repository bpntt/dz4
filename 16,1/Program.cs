int MunberInput( string text)
{
    Console.WriteLine(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

string ToBin(int num)
{
    string result = string.Empty;
    while (num>0)
    {
        result = num%2 + result;
        num/=2;
    }
    return result;
}

int number = MunberInput("Write your number");
Console.WriteLine(ToBin(number));