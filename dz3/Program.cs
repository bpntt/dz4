int LenghtArray (string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32 ( Console.ReadLine());
    return result;
}
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}
int a1 = LenghtArray("Введите число");
int[] arr = FillArray(a1);
PrintArray(arr);