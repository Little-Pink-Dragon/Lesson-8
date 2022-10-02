Console.Write("Введите количество строк в первой матрице: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в первой матрице: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b;
Console.Write("Введите количество столбцов во второй матрице: ");
int d = Convert.ToInt32(Console.ReadLine());
int[,] Matrix1 = new int[a, b];
int[,] Matrix2 = new int[c, d];
int[,] Matrix3 = new int[a, d];
FillArrayRandomNumbers(Matrix1);
FillArrayRandomNumbers(Matrix2);
Console.WriteLine("Первая матрица:");
PrintArray(Matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(Matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < d; j++)
    {
       for (int k = 0; k < c; k++)
        {
            Matrix3[i, j] = Matrix3[i, j] + (Matrix1[i, k] * Matrix2[k, j]);
        }
        
    }
}
PrintArray(Matrix3);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
