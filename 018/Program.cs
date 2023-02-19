int[] CreateArray(int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max +1);
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

int [] CopyArray(int [] array)
{
     int [] result = new int [array.Length];
     for (int i = 0; i < array.Length; i++)
     {
        result [i] = array[i];
     }
     return result;
}

int [] arr1 = CreateArray(9, 1, 10);
int [] arr2 = CopyArray(arr1);
PrintArray(arr1);
PrintArray(arr2);