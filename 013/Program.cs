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

string PrintArray(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
        result = i < (array.Length - 1) ? result = result + "," : result;
    }
    return result + "]";
}

int Maxint(int[] array)
{
    int max1 = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (max1 < array[i]) max1 = array[i];

    }
    return max1;

}
int Minunt(int[] array)
{
    int min1 = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min1 > array[i]) min1 = array[i];
    }
    return min1;

}

int size = 5, min = 10, max = 50;
int[] arr = CreateArrayInt(size, min, max);
string array1 = PrintArray(arr);
int findmax = Maxint(arr);
int FindMin = Minunt(arr);
int total = findmax - FindMin;
Console.WriteLine($"{array1}  min {FindMin}  max {findmax} =>   total   {total}  ");
