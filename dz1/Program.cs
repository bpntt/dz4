// хотел сделать через общий метод и отдельные методы для ввода - не получилось. дз 1.1 рабочее 

ouble NumberA(string text)
{
    Console.WriteLine(text);
    double a = Convert.ToDouble(Console.ReadLine());

    return a;
}
double NumberB(string text2)
{
    Console.WriteLine(text2);
    double b = Convert.ToDouble(Console.ReadLine());
    return b;
} 
/*  if (b < 0)
{
        Console.WriteLine("Second number can noy be less than 0");
        
    }  */
/*  double NumbeBToF(double b)
{
    if (b<0)
    {
        Console.WriteLine("Second number can noy be less than 0");
        return 0;
    }
    else 
    {
        return b;
    }
}  */
double AXB(double z, double r)
  {
    int sum = 1;
    int i = 0;
    while (i <= z)
    {
        sum = sum * r;
        i++;
    }

    return sum;
} 

 double f = NumberA("Write Your number");
double s = NumberB("Write Your second number"); 
double n = AXB(NumberA, NumberB);
Console.WriteLine($"{NumberA} raice to the {NumberB} ");