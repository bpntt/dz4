Console.WriteLine("Write Your number");
int number = Convert.ToInt32(Console.ReadLine());
int sum1 = MetSum (number);
Console.WriteLine ($"Sum = {sum1}");
int MetSum (int num) 
{
int sum = 0;
for (int i = 1; i <= num; i++)
{
    sum = sum + i;
}
return sum; 
}
