int[,] CreateMatrix(int rows, int collums, int min, int max)
{
    int[,] matrix = new int[rows, collums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int g = 0; g < matrix.GetLength(1); g++)
        {
            matrix[i, g] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {


        Console.Write("[");
        for (int g = 0; g < matrix.GetLength(1);g++)
        {
            if (g < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,g],4}" + ", ");
            else Console.Write($"{matrix[i,g], 4}");
        }
        Console.WriteLine("]");
    }
}

void Changematrix(int[,] matrix)
{
      for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int g = 0; g < matrix.GetLength(1); g+=2)
        {
          matrix[i,g]*=matrix[i,g];
        }
    }
}
int [,] Array2D = CreateMatrix(3,4,-1, 10);
PrintArray(Array2D);
Changematrix(Array2D);
PrintArray(Array2D);
