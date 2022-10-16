//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	//456 -> 6
	//782 -> 2
	//918 -> 8


Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int count = -N;

while (count <= N){
    if(count == N){
        Console.Write(count);
    } else {
    Console.Write(count + ",");
    }
    count++;
}