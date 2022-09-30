Console.WriteLine("Start");
Console.WriteLine("Введите день недели: ");
int dayWeek = int.Parse(Console.ReadLine());

switch (dayWeek)
{
    case 1:
    Console.WriteLine("Monday");
    break;

    case 2:
    Console.WriteLine("Tuesday");
    break;

    case 3:
    Console.WriteLine("Wednesday");
    break;

    case 4:
    Console.WriteLine("Thursday");
    break;

    case 5:
    Console.WriteLine("Friday");
    break;

    case 6:
    Console.WriteLine("Satruday");
    break;

    case 7:
    Console.WriteLine("Sunday");
    break;

    default:
    Console.WriteLine("Введите корректное значение! Иначе ничего не заработает!");
    break;
}