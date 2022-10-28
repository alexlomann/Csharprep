//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*Console.Write("Введите m = ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[strings, columns];
FillArray(numbers); PrintArray(numbers);

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/ 

//{===================================================================================================}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//i = 4, j = 2 -> такого числа в массиве нет
//i = 1, j = 2 -> 2

/*Console.Write("введите i = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите j = ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
FillArray(numbers); PrintArray(numbers); 

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){        
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}  
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine(" -> такого числа в массиве нет");
}
else
{
    Console.WriteLine($"i = {n}, j = {m} - > {numbers[n-1,m-1]}");
}*/


//{===================================================================================================}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


/*Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
FillArray(num); PrintArr(num);

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

for (int i = 0; i < num.GetLength(1); i++)
{
    double x = 0;
    for (int j = 0; j < num.GetLength(0); j++)
    {
        x = (x+ num[j, i]);
    }
    x = x / n;
    Console.Write(x + "; ");
}
Console.WriteLine();
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/


//{===================================================================================================}

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

/*#nullable disable
Console.Write("Введите первое: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите другое: ");
int two = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье: ");
int three = Convert.ToInt32(Console.ReadLine());

int count = 89;
if (one* two * three > count)
{
    Console.WriteLine("Сей массiвъ огромен!");
    return;
}

int[,,] res = arr(one, two, three);

for (int i = 0; i < res.GetLength(0); i++)
{
    for (int j = 0; j < res.GetLength(1); j++)
    {
        for (int k = 0; k < res.GetLength(2); k++)
        {
            Console.Write($"{res[j,k, i]} ({j},{k},{i})");
        }
        Console.WriteLine();
    }
}

int[,,] arr(int size1, int size2, int size3)
{
    int[,,] arr = new int[size1, size2, size3];
    int[] val = new int[count];
    int num = 10;
    for (int i = 0; i < val.Length; i++)
        val[i] = num++;

    for (int i = 0; i < val.Length; i++){
        int randomIndex= new Random().Next(0, val.Length);
        int tmp = val[i];
        val[i] = val[randomIndex];
        val[randomIndex] = tmp;
    }

    int valueIndex = 0;

    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = val[valueIndex++];
            }
        }
    }
    return arr;
}*/


//{===================================================================================================}

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

// только думаю как это сделать(( in progress