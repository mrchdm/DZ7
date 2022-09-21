/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

//Метод создания двумерного массива
int[,] CreateArr(int n, int m ) //где m- колчичество строк, а n - количество столбов
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    return arr;
}


Console.WriteLine("Введите номер строки элемента");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента");
int b = Convert.ToInt32(Console.ReadLine());
double ArithmeticalMean = 0;
int[,] array = CreateArr(a, 4);

for (int i = 0; i < array.GetLength(1); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
    sum += array[j,i];
    }       
       ArithmeticalMean = sum/ a;
       Console.Write($" {ArithmeticalMean}");
}
