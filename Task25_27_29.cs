//--------------------------------------------------------------------------------ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ---------------------------------------------------------



//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*Console.WriteLine("Ввведите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввведите число B: ");
int B = int.Parse(Console.ReadLine()!);


Console.Write($"А в степени В будет {GetPower(A)}");

// функция возведения числа А в степень В
int GetPower(int method){
    int pow = 1;
    for (int i = 1; i <= B; i++){

        pow = pow*A;
    }

    return pow;
}*/



//{===================================================================================================}



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/* int num = InputNum("Введите число: ");

// Вывод результата
int summa = NumCount(num);
Console.WriteLine($"Cумма цифр: {SumNum(num, summa)}");

// Ввод числа 
int InputNum(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция NumCount считает цифры 
int NumCount(int x)
{
    int count = 0;
    while (x > 0){
        x = x / 10;
        count++;
    }
    return count;
}
// Функция SumNum складывает числа
int SumNum(int x, int summa)
{
    int sum = 0;
    for (int i = 1; i <= summa; i++){
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
} */



//{===================================================================================================}


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/* int[] mas = ArrayEightNumbers(8);
Console.WriteLine($"[{String.Join("," , mas)}]");

int[] ArrayEightNumbers (int Arr){
int[] randArr = new int[8];
for (int i = 0; i < randArr.Length; i++){
    randArr[i] = new Random().Next(1,9);
}
return randArr;
} */

