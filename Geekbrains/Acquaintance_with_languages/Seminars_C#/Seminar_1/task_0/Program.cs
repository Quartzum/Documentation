//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.Write("Квадрат числа " + number + " равен = " + sqr);