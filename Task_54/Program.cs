// Задать двумерный массив.
// Упорядочить по убыванию элементы каждой строки.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10); // [1, 9]
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
void OrderedMatrix(int[,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++) 
    {      
      for (int j = 0; j < matrix.GetLength(1); j++) 
      {
          for (int k = j + 1; k < matrix.GetLength(1); k++) 
          {
              if (matrix[i, k] > matrix[i, j])
              { 
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;                      
              }
          }
      }      
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Конечный массив:");
OrderedMatrix(matrix);
PrintMatrix(matrix);
