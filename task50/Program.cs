/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

//Метод создания двумерного массива
int[,] CreateArr( int n, int m) //где m- колчичество строк, а n - количество столбов
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

int[,] array = CreateArr(2, 4);

Console.WriteLine("Введите номер строки элемента");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента");
int b = Convert.ToInt32(Console.ReadLine());

if (a < array.GetLength(0) && b < array.GetLength(1))
{
    Console.WriteLine(array[a, b]);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
