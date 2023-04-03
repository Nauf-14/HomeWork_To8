// Трёхмерный массив из неповторяющихся двузначных чисел.
// Построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1
int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
{
    int[,,] matrix3D = new int[row, col, dep];
    Random rnd = new Random();   
    for (int i = 0; i < matrix3D.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
                {
                    matrix3D[i,j,k] = rnd.Next(min, max + 1);
                }
        }
    }
    return matrix3D;
}
void InputMatrix(int[, ,] matrix3D)
{
    for 
    (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
          for (int k = 0; k < matrix3D.GetLength(2); k++)
            matrix3D[i, j, k] = new Random().Next(10, 101); // [10; 100]
        }
    }
}

void PrintMatrix(int[, ,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
          for (int k = 0; k < matrix3D.GetLength(2); k++)
          {
            Console.WriteLine($"{matrix3D[i, j, k]} ({i}, {j}, {k}) \t");
          }
        }
    }
    Console.WriteLine();
        
}


Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[, ,] matrix3D = new int[size[0], size[1], size[2]];
int[, ,] array3D = CreateMatrix(2, 2, 2, 10, 101);
InputMatrix(matrix3D);
PrintMatrix(matrix3D);