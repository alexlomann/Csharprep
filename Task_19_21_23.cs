// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)
//14212 -> нет
//12821 -> да
//23432 -> да

/*#nullable disable
Console.Write("Вводи пятизначное число для палиндромной проверки: ");
string num = Console.ReadLine();
int len = num.Length;

if (len > 5)
{
    Console.WriteLine("Именем Империи и канцлера Палпатина! Вводи ПЯТИзначное!");
}
else {
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - да");
    }
    else
    {
        Console.WriteLine($"{num} - нет");
    }
}*/

//{===================================================================================================}

//Задача 21: Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*Console.Write("Введите координату Х точки отправления: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки отправления: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки отправления: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х точки назначения: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки назначения: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки назначения: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int X = x2 - x1;
int Y = y2 - y1;
int Z = z1 - z2;

double distance = Math.Sqrt(X * X + Y * Y + Z * Z);
Console.WriteLine($"Расстояние между координатами в Галактике через Дугу Кесселя: {distance - distance % 0.01} парсек");*/


//{===================================================================================================}

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/* Console.Write("Вводи число N: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{ 
    Console.Write($"{i*i*i}, ");
}
 */