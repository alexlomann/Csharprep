//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/* Console.WriteLine("Сколько чисел должно быть в массиве:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArr(numbers); PrintArr(numbers);

// метод заполнения массива
void FillArr(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100500);
    }
}

// подсчет четных
int count = 0;
for (int x = 0; x < numbers.Length; x++)
    if (numbers[x] % 2 == 0)
        count++;
Console.WriteLine($" -> {count} ");

// вывод массива
void PrintArr(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
} */


//{===================================================================================================}


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/* Console.WriteLine("Сколько чисел должно быть в массиве:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArr(numbers); PrintArr(numbers);

// поиск четных и их суммы
int sum = 0;
for (int x = 0; x < numbers.Length; x = x + 2)
    sum = sum + numbers[x];
Console.WriteLine($" -> {sum}");

// метод заполнения
void FillArr(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
}

// метод вывода массива
void PrintArr(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
} */


//{===================================================================================================}


//Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/* Console.WriteLine("Сколько чисел должно быть в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArr(numbers); PrintArr(numbers); MinMaxMothod(numbers);

// заполнение массива
void FillArr(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(new Random().Next());
    }
}
// печать массива
void PrintArr(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

//разница между максимальным, минимальным + печать
void MinMaxMothod(int[] numbers)
{
    int min = Int32.MaxValue;
    int max = Int32.MinValue;

    for (int x = 0; x < numbers.Length; x++)
    {
        if (numbers[x] > max){
            max = numbers[x];
        }
        if (numbers[x] < min){
            min = numbers[x];
        }
    }
    Console.WriteLine($" -> {max - min}");
} */