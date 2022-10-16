void Print(){
Console.Clear();
Console.WriteLine("Start");
Console.Write("Введите число с тремя цифрами: ");
int num = int.Parse(Console.ReadLine());
Error(num);
Decompasition(num);
int result = (Decompasition(num));
Console.WriteLine($"Третья цифра числа: {num} - {result}.");
Console.WriteLine("End");
}

void Error(int value){
    if(value < 99 && value > -99 ){
        Console.WriteLine($"В числе: {value}, нет третьей цифры! Введите корректное число!");
        Environment.Exit(0);
    }
}

int Decompasition(int value){
    if(value < 999)
    return value % 10;
    int nextValue = value / 10;
    return Decompasition(nextValue);
}

Print();