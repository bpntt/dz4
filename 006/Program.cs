int [] CreateArrayInt (int size, int min, int max)
{
int [] array = new int[size];
Random rnd = new Random ();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(min, max + 1);
}
return array;
} 

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
{
   if (i < array.Length -1) Console.Write(array[i] + ", ");
   else Console.Write (array [i]);
}
Console.WriteLine("]");
}
int GetSumPositive( int [] array )
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sum += array[i];
}
return sum;
}

int GetSumNegative( int [] array )
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]< 0) sum += array[i];
}
return sum;
}

int [] arr = CreateArrayInt (12, -9, 9);
PrintArray( arr); 

int SumPositive = GetSumPositive( arr);
int SumNegative = GetSumNegative (arr);
Console.WriteLine($"sum positive = {SumPositive}");
Console.WriteLine($"sum positive = {SumNegative}");