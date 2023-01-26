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

/* int [] ReversPositive (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]< 0) i* -1;
    }
    return;
}

int [] ReversPositive (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> 0) i* -1;
    }
    return;
} */

/*  int Revers(int [] origin)
{
    Console.Write("[");
   for (int i = 0; i < origin.Length; i++)
{
   if (i < origin.Length -1) Console.Write(origin[i] * -1 + ", ");
   else Console.Write (origin [i] * -1);
}
Console.WriteLine("]");
} */

void PrintArray2(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
{
   if (i < array.Length -1) Console.Write(array[i]* -1 + ", ");
   else Console.Write (array [i] * -1);
}
Console.WriteLine("]");
}

int [] arr = CreateArrayInt (12, -9, 9);
PrintArray( arr); 
PrintArray2 (arr);
