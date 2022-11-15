//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/* #nullable disable
Console.WriteLine("Задайте значение N:");
int num = int.Parse(Console.ReadLine());
RecursionMethod(num);

void RecursionMethod (int num)
{
    if (num == 0) return;
    Console.Write("{0,2}", num);
    RecursionMethod (num - 1);
    
} */



//{===================================================================================================}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/* int numberM = InputValue("Значение M:");
int numberN = InputValue("Значение N:");

void NumSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumSum(numberM, numberN, sum);
}

NumSum(numberM, numberN, 0);

int InputValue(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
 */
//{===================================================================================================}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/* int numberM = InputValue("Значение M:");
int numberN = InputValue("Значение N:");

int AkermanFunc (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AkermanFunc(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkermanFunc(numberM - 1, AkermanFunc(numberM, numberN - 1));
    return AkermanFunc(numberM, numberN);
}

Console.WriteLine($"Aккерман сообщает: А({numberM},{numberN}) = {AkermanFunc(numberM, numberN)}");

int InputValue(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
} */