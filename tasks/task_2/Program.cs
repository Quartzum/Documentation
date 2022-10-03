// Найти максимальное и минимальное четное число
Console.WriteLine("Start");

int one = 1000;
int two = -30;

if(one % 2 == 0 && two % 2 == 0){
    if(one > two){
        Console.WriteLine("Максимальное четное число - " + one);
        Console.WriteLine("Минимальное четное число - " + two);
    } else {
        Console.WriteLine("Максимальное четное число - " + two);
        Console.WriteLine("Минимальное четное число - " + one); 
    }
} else{
    Console.WriteLine("Одно из чисел нечетное. Введите корректное число!");
}
// Найти максимальное и минимальное нечетное число
Console.WriteLine("Start");

int one_1 = 33;
int two_1 = 3;

if(one_1 % 2 == 1 && two_1 % 2 == 1){
    if(one_1 > two_1){
        Console.WriteLine("Максимальное нечетное число - " + one_1);
        Console.WriteLine("Минимальное нечетное число - " + two_1);
    } else {
        Console.WriteLine("Максимальное нечетное число - " + two_1);
        Console.WriteLine("Минимальное нечетное число - " + one_1); 
    }
} else{
    Console.WriteLine("Одно из чисел четное. Введите корректное число!");
}

if(one_1 % 2 == 1){
    Console.WriteLine("Работает корректно");
}

//При попытки взять остаток от отрицательного числа он его считает не как нечетное число.

//Найти максимальное и минимальное натуральное число