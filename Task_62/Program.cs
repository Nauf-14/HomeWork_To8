// Напишите программу, которая заполнит спирально массив 4 на 4.
void SnakeMatrix(int[,] matrix)
{
int[,] arr = new int [4, 4];
int num = 1;// Задаем начальные значения для координат и числа, которое будем записывать
int left = 0, right = 3, top = 0, bottom = 3;// Определяем переменные для границ массива
while (left <= right && top <= bottom)// Основной цикл
  {
    for (int i = left; i <= right; i++)// Заполняем верхнюю строку слева направо
    {
        matrix[top, i] = num++;
    }
    top++;
    for (int i = top; i <= bottom; i++)// Заполняем правый столбец сверху вниз
    {
        matrix[i, right] = num++;
    }
    right--;
    for (int i = right; i >= left; i--)// Заполняем нижнюю строку справа налево
    {
        matrix[bottom, i] = num++;
    }
    bottom--;
    for (int i = bottom; i >= top; i--)  // Заполняем левый столбец снизу вверх
    {
        matrix[i, left] = num++;
    }
    left++;
  }
  for (int i = 0; i < matrix.GetLength(0); i++)// Выводим результат на экран
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j] + " "}\t");
    }
    Console.WriteLine();
  }
}
Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

SnakeMatrix(matrix);


