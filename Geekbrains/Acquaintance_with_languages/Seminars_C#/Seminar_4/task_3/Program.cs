/*## Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

void Print()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.Write("Введите число: ");
    int ResultCircle = Circle();
    Console.WriteLine($"{ResultCircle}");
    Console.WriteLine("End");
}

int GetNumber()
{
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Circle()
{
   int number = GetNumber();
   int result = 1;
   
   while ( number > 0 )
   {
     result = result * number;
     number--;
   }
   return result;
}

Print();