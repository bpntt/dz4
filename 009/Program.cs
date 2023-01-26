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
int count( int [] array)
{
    int cou = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( 10 < array[i] && array[i] <99 ) cou = cou + 1;
    }
    return cou;
}

int [] arr = CreateArrayInt (123, 0 , 124);
PrintArray( arr); 
int total = count( arr);
Console.WriteLine($"count {total}");