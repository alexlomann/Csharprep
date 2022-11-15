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

/*int mas = 4;
int[,] spiral = new int[mas, mas];

FillArr(spiral, mas);
PrintArr(spiral);

void FillArr(int[,] arr, int n)
{
int count = 1;
int i = 0;
int j = 0;

while (count <= spiral.GetLength(0) * spiral.GetLength(1))
{
  spiral[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < spiral.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiral.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiral.GetLength(1) - 1)
    j--;
  else
    i--;
}
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/


//{===================================================================================================}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

/*Console.Write("Строк будет: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов будет: ");
int two = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[one, two];

FillArrayRandomNumbers(numbers); 

Console.WriteLine("Например, задан массив: ");
PrintArray(numbers); 

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1])
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}

Console.WriteLine("В итоге получается вот такой массив:");
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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/


//{===================================================================================================}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*Console.WriteLine("Задайте размер массива");
Console.WriteLine();
int m = SizeMatrix("Количество строк: ");
int n = SizeMatrix("Количество столбцов: ");
int[,] arr = new int[m, n];
FillArrayRandomNum(arr);
PrintArray(arr);
Console.WriteLine();
MinSumNumbers(arr);

void MinSumNumbers(int[,] array){

    int min = 0, minSum = 0, sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        min += arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {minSum + 1} ");
}

int SizeMatrix(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArrayRandomNum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}*/

// Функция заполнения массива рандомно числами от 1 до 9

//{===================================================================================================}

//Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

/*int size = SizeMatrix("Размер квадратной матрицы будет: ");
int[,] matrixNeo = new int[size, size];
int[,] matrixSmith = new int[size, size];
int[,] matrixMorph = new int[size, size];

FillArrayRandomNum(matrixNeo);
FillArrayRandomNum(matrixSmith);


for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixMorph[i, j] = matrixMorph[i, j] + (matrixNeo[i, k] * matrixSmith[k, j]);
        }
    }
}

int SizeMatrix(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArrayRandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Матрица Нео: ");
PrintArray(matrixNeo);
Console.WriteLine();
Console.WriteLine("Матрица Смита: ");
PrintArray(matrixSmith);
Console.WriteLine();
Console.WriteLine("Морфиус посчитал, что результирующая матрица будет:");
PrintArray(matrixMorph);*/