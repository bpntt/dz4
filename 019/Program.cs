string[,] table = new string [2,5];
//srting.Empty
table[1, 2] = "word";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"--{table[rows, columns]}--");
    }
}

int [,] matrix = new int [3,4];
void PrintAray(int [,] mat)
{
for (int i = 0; i < 3; i++)
{
    for (int e = 0; e < 4; e++)
    {
         Console.Write($"--{matrix[i, e]}--");
    }
    Console.WriteLine();
}
}
void FillaArray (int [,]matr)
{
    for (int q = 0; q <matr.GetLength(0); q++)
    {
        for (int w = 0; w < matr.GetLength(1); w++)
        {
            matr [q,w] = new Random().Next(1,10);
        }
    }
}
PrintAray (matrix);
FillaArray(matrix);
PrintAray (matrix);