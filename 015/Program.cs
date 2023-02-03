bool Check (int a, int b, int c)
{
    if (a+b<c || a+c <b|| b+c< b) return true;
    else return false;
}
Console.WriteLine("Write 1 side");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write 2 side");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write 2 side");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Check(a, b, c) ? "yes" : "no" );
