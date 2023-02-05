/* ДЗ 1
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " > " + secondNumber);
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine(secondNumber + " > " + firstNumber);
}
else
{
    Console.WriteLine(secondNumber + " = " + firstNumber);
}
*/

/* 
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}
*/
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
    {
        Console.WriteLine(number + " - Четное число: ");
    }
    else
    {
        Console.WriteLine(number + " - Нечетное число");
    }
*/
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;


while(startNumber <= number)
    {
        if(startNumber % 2 ==0)
        Console.Write(startNumber + ", ");
        startNumber ++;
    }

*/

/*
//Функционал 
int number1 = 5; 
int number2 = 8;
Console.WriteLine($"My numbers are {number1} + and + {number2} + and it's good");
// 
*/ 
/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
// 
*/
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.Readline());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2; 

if(num1 == quad2) 
{
   Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/ 

//Задача 2
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while(current <= n)
{
    Console.Write(current + " ");
    current++; 
}
*/

///Задача 3 

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*a = 5
b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 


Console.Write("Введите Ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, Анастасия");
Console.Write(username); 

int numberA = 12;
int numberВ = 5;
int result = numberA + numberВ;
Console.WriteLine(result);

int numberA = 10;
int numberB = 5;
Console.WriteLine(numberA / numberB);
*/ 

