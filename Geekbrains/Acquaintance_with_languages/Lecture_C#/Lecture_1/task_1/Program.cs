/*
Человек вышел из дома и движется со скоростью 5 км/ч. Также навстречу ему движется другой человек со скоростью 5 км/ч. 
После того, как первый человек прошел 1 км навстречу к нему побежала собака, которая двигалась ко второму человеку со 
скоростью 10 км/ч. Какое расстояние собака пробежала между людьми, если расстояние между ними во время выхода первого 
человека было 20 км?
*/

class Programm{
    public static void Main()
    {
        int TotalDistance = 0;
        int SpeedFirstHuman = 0;
        int SpeedSecondHuman = 0;
        int SpeedDog = 0;
    }

    public static void Print()
    {
        Console.WriteLine("Start");
        GetVariables();
        Console.WriteLine("End");
    }

    public static void GetVariables()
    {
        Console.WriteLine("Введите общее расстояние: ");
        TotalDistane = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите скорость первого человека: ");
        SpeedFirstHuman = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите скорость второго человека: ");
        SpeedSecondHuman = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите скорость собаки: ");
        SpeedDog = int.Parse(Console.ReadLine());
    }

    public static int CalculateDistance(){
       
    }
}