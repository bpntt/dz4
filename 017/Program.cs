int [] ArrayF(int count)
{
    int [] result = new int [count];
    result [1] = 1;
    for (int i = 2; i < count; i++)
    {
        result[i] = result[i-1] + result[i-2];


    }
    return result;
}

int NumberInput(string text)
{
    Console.WriteLine(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
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


int number = NumberInput("Write your number");
int [ ] arr = ArrayF(number);
PrintArray(arr);
