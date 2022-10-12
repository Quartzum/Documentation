/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта точка.
*/

Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0){
    Console.WriteLine("Точка находится в первой области");
} else if(x < 0 && y < 0){
    Console.WriteLine("Точка находится в третьей области");
} else if(x < 0 && y > 0){
    Console.WriteLine("Точка находится во второй области");
} else if(x > 0 && y < 0) {
    Console.WriteLine("Точка находится в четвертой области");
} else {
    Console.WriteLine("Точка с координатами - 0 и 0 не находится ни в одной из областей");
}
Console.WriteLine("End");
