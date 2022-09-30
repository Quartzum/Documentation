//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	//456 -> 6
	//782 -> 2
	//918 -> 8

//Console.WriteLine("Введите значение числа n: ");
//string text = Console.ReadLine();
//int y = text[text.Length - 1] - '0';
//int n = y * y;
//Console.WriteLine("n в квадрате = {0, 3}", n);
//Console.WriteLine("Последнее число", y);

// Деление с остатком

Console.WriteLine("Введите число: ");
int someNumber = int.Parse(Console.ReadLine());
int result = someNumber % 10;
Console.WriteLine(result);