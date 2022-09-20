/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк, затем количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double[m, n]; 

for( int i = 0; i < m; i++)
{
    for( int j = 0; j < n; j++)
    {
        arr[i, j] = arr[i, j] = new Random().NextDouble() * new Random().Next(1,10) ;
        Console.Write($"{arr[i,j]}  ");
    }
    Console.WriteLine();
}