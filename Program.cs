/*Console.WriteLine("Введите трехзначное число);
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
    */

    /*int num = new Random().Next(10,100);

int num1 = num/10;
int num2 = num%10;

int max = num1;

if(max < num2){
    max = num2;
}

Console.WriteLine($"Максимальная цифра числа {num} равна {max}");*/


//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98 

/*int num = new Random().Next(100,1000);
int num1 = num/100;
int num3 = num%10;

int res = num1*10 + num3;


Console.WriteLine($"Тайное число{res}");*/


/*int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

if(num1 % num2 == 0){
    Console.WriteLine("Второе кратно первому");
}
else{
    Console.WriteLine("Второе НЕ кратно первому. Остаток: " + num1 % num2);
}*/

//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да 

/*int num = int.Parse(Console.ReadLine()!);

if ((num % 7 == 0) && (num % 23 == 0)){
    Console.Write($"Число {num} кратно");
}
else{
    Console.Write($"Число {num} NE кратно");
}*/


/*int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

if ((num1 == Math.Pow(num2,2) || num2 == Math.Pow(num1,2))){
    Console.Write($"Число {num1} квадрат {num2}");
}
else{
    Console.Write($"Число {num1} квадрат {num2}");
}*/
