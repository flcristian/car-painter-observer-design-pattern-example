using car_painter_observer_pattern_example;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car("Subaru", "WRX STI", 2018);
        CarPart frontDiffuser = new CarPart("Front diffuser");
        CarPart rearDiffuser = new CarPart("Rear diffuser");
        CarPart rearWing = new CarPart("Rear wing");
        car.AddPart(frontDiffuser);
        car.AddPart(rearDiffuser);
        car.AddPart(rearWing);

        car.Paint("Blue");
        Console.WriteLine(car);
    }
}