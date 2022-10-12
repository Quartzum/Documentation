/*
Задача 22: Напишите программу,которая принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

public class Programm
{
    public static void Main(){
        Console.Clear();
        SquareNumber squareNumber = new SquareNumber();
        squareNumber.GetNumber();
        squareNumber.WriteTableSquare();
    }
}

public class SquareNumber{
    int number;

    public void GetNumber(){
        Console.Write("Введите целое число: ");
        number = int.Parse(Console.ReadLine());
    }
    public void WriteTableSquare(){
        while(number >= 1){
            double result = Math.Pow(number, 2);
            Console.Write($"{result} <= ");
            number--;
        }
    }
}