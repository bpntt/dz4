double [,] CreateMatrix(int rows, int collums, int min, int max)
{
    double [,] matrix = new double [rows, collums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int g = 0; g < matrix.GetLength(1); g++)
        {
            matrix[i, g] = Convert.ToDouble(new Random().Next(min, max)) / 10;
        }
    }
    return matrix;
}

void PrintArray(double [,] matrix)
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
double [,] Array2D = CreateMatrix(4,4,-10, 10);
PrintArray(Array2D);