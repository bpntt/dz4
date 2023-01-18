Console.WriteLine("Write Your number");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write Your second number");
double b = Convert.ToDouble(Console.ReadLine());
double sum = Sum1(a,b);
if (b < 0)
{
    Console.WriteLine("Second number can noy be less than 0");
    return;
}


double Sum1(double a, double b)
{
    double  result = 1;
    int i = 1;
    
   while  (i <= b )
    {
        result = result * a;
         i++;
    }
    return result;
    
}
Console.WriteLine($"{a} raice to the {b} power is {sum}");