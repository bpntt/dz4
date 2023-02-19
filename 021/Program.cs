int Factorial(int n)
{
    if(n==1)return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(6));


int Fib(int m)
{
    if (m == 1|| m ==2) return 1;
    else return Fib(m-1) + Fib(m-2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fib(i));
}