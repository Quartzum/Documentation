// 1.Функция, которая не принимает аргументы и ничего не возвращает.
void FirstMethod()
{
    Console.WriteLine("Hi");
}
FirstMethod();
// 2.Функция, которая прининимает аргументы и ничего не возвращает.
void SecondMethod(string arg1,int arg2)
{
    Console.WriteLine(arg1);
    Console.WriteLine(arg2);
}
SecondMethod("Hi", 2);
SecondMethod(arg1:"Hi",arg2: 2);//Если нужно точно указать аргументы.
// 3.Функция, которая не принимает аргументы и возвращает результат работы метода.
int ThirdMethod()
{
    int count = 10;
    count += 1;
    return count;
}
int FirstNumber = ThirdMethod();
// 4.Функция, которая принимает аргументы и возвращает результат работы метода.
int FourMethod(int arg1, int arg2)
{
    int count = arg1 + arg2;
    return count;
}
int SecondNumber = FourMethod(5,6);