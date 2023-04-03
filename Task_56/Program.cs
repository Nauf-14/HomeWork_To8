// Прямоугольный двумерный массив.
// Находим строку с наименьшей суммой элементов.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [10; 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
void MinRowMatrix(int[,] matrix)
{
int minRowIndex = 0;
int minRowSum = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        
            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }
    }
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1}");
   
    
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
MinRowMatrix(matrix);
