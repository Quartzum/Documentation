void Print(){
    Console.Clear();
    Console.WriteLine("Start");
    Console.Write("Введите цифру дня недели:");
    uint num = uint.Parse(Console.ReadLine());
    int[]numbers = {1,2,3,4,5,6,7};

    if(num == numbers[5] || num == numbers[6]){
        Console.WriteLine($"{num} - выходной!");
    } else if(num == 0) {
        Console.WriteLine($"{num} - такого дня не существует!");
    } else {
        Console.WriteLine($"{num} - рабочий день!");
    }
    Console.WriteLine("End");
}

Print();