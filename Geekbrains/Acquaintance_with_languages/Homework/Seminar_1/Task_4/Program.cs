Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите число: ");
int NaturalNumbers = int.Parse(Console.ReadLine());
int count = 1;

Console.Write("Четные числа в промежутке от 1 до " + NaturalNumbers + " - ");
while(count < NaturalNumbers){
    if (count + 2 == NaturalNumbers){
        Console.Write(count);
    } else if (count % 2 == 0){
        Console.Write(count + ", ");
    }
count++;
}

