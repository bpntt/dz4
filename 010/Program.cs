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

string PrintArray(int [] array)
{
   string result = "[";
    for (int i = 0; i < array.Length; i++)
{
   result = result + $" {array[i]}";
   result = i < (array.Length - 1) ? result = result + "," : result;
}
return result + "]";
}


int [] FinalArray (int [] array)
{
    int size = array.Length %2 != 0 ? array.Length/ 2 + 1: array.Length /2;
    int [] array3 = new int[size];
    for (int i = 0; i < array3.Length; i++)
    {
        array3[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 ==1) array3[size-1] = array[array.Length /2];
    return array3;
}

int size = 5 , min = 0, max = 10;

int [] arr = CreateArrayInt (size, min, max);
string array1 = PrintArray( arr); 
int [] final1 = FinalArray(arr);
string array2 = PrintArray (final1);
Console.WriteLine($"{array1} => {array2}  ");