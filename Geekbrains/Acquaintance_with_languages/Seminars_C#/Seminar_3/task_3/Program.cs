public class Program
{
	public static void Main()
	{
    	DistanceCalculator distanceCalculator = new DistanceCalculator();
    	distanceCalculator.Init();
    	distanceCalculator.Output();
	}
}


public class DistanceCalculator {
    int FirstCoordinate, SecondCoordinate, ThirdCoordinate, FourCoordinate;
    
    public void Init()
    {
        FirstCoordinate = GetCoordinate();
        SecondCoordinate = GetCoordinate();
        ThirdCoordinate = GetCoordinate();
        FourCoordinate = GetCoordinate();
    }
    
    int GetCoordinate(){
    Console.Write("Введите координату:");
    int result = int.Parse(Console.ReadLine());
    return result;
    }
    
    int CalcDistance(){
    int result = Convert.ToInt32(Math.Sqrt((Math.Pow((FirstCoordinate + SecondCoordinate), 2)) + (Math.Pow((ThirdCoordinate + FourCoordinate), 2))));
    return result;
    }
    
    public void Output(){
    Console.Clear();
    }
}