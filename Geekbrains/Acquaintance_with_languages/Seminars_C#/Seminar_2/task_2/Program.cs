/*11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

Console.WriteLine("Start");
int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число равно - {num}");

int a1 = num / 100;
int a2 = num / 10 % 10;
int a3 = num % 10;

Console.WriteLine(num);
//Console.WriteLine($"{a1}");
//Console.WriteLine($"{a2}");
//Console.WriteLine($"{a3}");
Console.WriteLine($"{a1}{a3}");




