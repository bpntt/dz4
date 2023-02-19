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
int FinalScore(int[] array)
{
    int total = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        if (i % 2 == 0) total = total + array[i] ;
    }

    return total;
}
int size = 5, min = 0, max = 5;

int[] arr = CreateArrayInt(size, min, max);
string array1 = PrintArray(arr);
int sum = FinalScore(arr);
Console.WriteLine($"{array1} сумма четных значений массива => {sum}  ");
