
int[] CreateArrayInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
bool foun ( int[] array, int found )
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == found) return true;

    }
    return false;
}


int[] arr = CreateArrayInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine("write your number");
int found = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(foun(arr, found) ? "no" : "yes");