﻿int [] CreateArray (int size, int max, int min)
{
int [] array = new int [size];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(min, max+1);
}
return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

void ReversArray(int [] array)
{
for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length-1 - i]; 
    array[array.Length-1 - i] = temp;
}
}

int size = 5, min = 10, max = 1;
int[] arr = CreateArray(size, min, max);
PrintArray(arr);
ReversArray(arr);
PrintArray(arr);
