Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Задан массив:");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int x = 0; x < numbers.GetLength(1) - 1; x++)
        {
            if (numbers[i, x] < numbers[i, x + 1])
            {
                
                int variable = 0;
                variable = numbers[i, x];
                numbers[i, x] = numbers[i, x + 1];
                numbers[i, x + 1] = variable;
            }  
        }
    }
}
Console.WriteLine();
Console.WriteLine("Упорядочиваем массив от большего к меньшему:");
PrintArray(numbers);

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