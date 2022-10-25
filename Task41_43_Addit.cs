//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1,-7,567,89,223-> 3

/* #nullable disable
Console.Write("Введи тайные числа Ситхов (через запятую): ");
string num = Console.ReadLine();
string[] newArr = new string[num.Length];

int x = 0;
for (int i = 0; i < newArr.Length; i++)
{
    if (num[i] == ',' || num[i] == ' ')
    {
        x++;
    }
    else
    {
        newArr[x] = newArr[x] + $"{num[i]}";
    }
}
x++;

int[] Numbers = new int[x];
PrintArr(Numbers, newArr);
int NumSum = 0;
for (int i = 0; i < x; i++)
{
    if (Numbers[i] > 0)
    {
        NumSum++;
    }
}

Console.WriteLine("-> " + NumSum);

// метод печати массива
void PrintArr(int[] arr, string[] str)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(str[i]);
        Console.Write(arr[i] + " ");
    }

} */


//{===================================================================================================}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

PoiskKoordinat();

void PoiskKoordinat(){
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"Координаты указывают на пересечение гиперпространственных маршрутов в системе Внешнего Кольца X: {x}, Y: {y}");
}*/


//{===================================================================================================}

//Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)
//Найти произведение всех элементов массива целых чисел, меньших заданного числа. 
//Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.

/* #nullable disable
Console.Write("Введите размер массива: ");
   int[] arr = new int[int.Parse(Console.ReadLine())];
   for (int i = 0; i < arr.Length; i++)
   FillArr(arr);

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(50, 100);
    }
}
Console.Write("Введенный массив: ");  
int mult = 1;
for (int i = 0; i < arr.Length; i++)
   Console.Write(arr[i]+" ");

   for (int i = 0; i < arr.Length-1; i++)
   {
      mult *= arr[i];
}       
Console.WriteLine("\nПроизведение элементов массива меньше заданного числа (не включая это число)" + arr.Length + ": " + mult);
 */