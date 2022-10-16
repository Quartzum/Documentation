/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void Print(){
Console.Clear();
Console.WriteLine("Start");
int [] array = new int[8];
Array(array);
Console.WriteLine("End");
}

void Array( int[]array ){

    for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write($"{array[i]} ");
}
}

Print();

