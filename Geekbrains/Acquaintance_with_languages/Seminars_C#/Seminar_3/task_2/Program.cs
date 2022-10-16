/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
координат точек в этой четверти (x и y).
*/

Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

if(num == 1){
    Console.WriteLine("Коориданата x -> от Infinity до 1; Координата y -> от Infinity до 1");
}
if(num == 2){
    Console.WriteLine("Коориданата x -> от -Infinity до -1; Координата y -> от Infinity до 1");
    
}
if(num == 3){
    Console.WriteLine("Коориданата x -> от -Infinity до -1; Координата y -> от -Infinity до -1");
    
}
if(num == 4){
    Console.WriteLine("Коориданата x -> от Infinity до 1; Координата y -> от -Infinity до -1");
    
}
else
{
    Console.WriteLine("Введите четверь от 1 до 4");
}

Console.WriteLine("End");