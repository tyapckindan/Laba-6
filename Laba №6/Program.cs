abstract class Transport
{
    public abstract int Speed { get; set; }
    public abstract int LoadCapacity { get; set; }
    public abstract int Distance { get; set; }
    public abstract void GetSpeed();
    public abstract void GetLoadCapacity();
    public abstract void GetDistanse();
}

abstract class Auto : Transport
{
    protected Auto(int speed, int loadCapacity, int distance)
    {
        Speed = speed;
        LoadCapacity = loadCapacity;
        Distance = distance;
    }
    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int Distance { get; set; }

}

abstract class Plane : Transport
{
    protected Plane(int speed, int loadCapacity, int distance)
    {
        Speed = speed;
        LoadCapacity = loadCapacity;
        Distance = distance;
    }

    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int Distance { get; set; }
}

abstract class Ship : Transport
{
    protected Ship(int speed, int loadCapacity, int distance)
    {
        Speed = speed;
        LoadCapacity = loadCapacity;
        Distance = distance;
    }

    public override int Speed { get; set; }
    public override int LoadCapacity { get; set; }
    public override int Distance { get; set; }
}

class Passenger_Car : Auto
{
    public string CarName { get; set; }
    public Passenger_Car(int Speed, int LoadCapacity, int Distance, string carName) : base(Speed, LoadCapacity, Distance)
    {
        CarName = carName;
    }

    public override void GetSpeed() => Console.WriteLine($"Скорость {CarName} - {Speed}");
    public override void GetDistanse() => Console.WriteLine($"Дистанция {CarName} - {Distance}");
    public override void GetLoadCapacity() => Console.WriteLine($"Грузоподьёмность {CarName} - {LoadCapacity}");
}

class Passenger_Aircraft : Plane
{
    public string AircraftName { get; set; }
    public Passenger_Aircraft(int Speed, int LoadCapacity, int Distance, string aircraftName) : base(Speed, LoadCapacity, Distance)
    {
        AircraftName = aircraftName;
    }
    public override void GetSpeed() => Console.WriteLine($"Скорость {AircraftName} - {Speed}");

    public override void GetLoadCapacity() => Console.WriteLine($"Дистанция {AircraftName} - {Distance}");

    public override void GetDistanse() => Console.WriteLine($"Грузоподьёмность {AircraftName} - {LoadCapacity}");
}

class Passenger_Ship : Ship
{
    public string ShipName { get; set; }
    public Passenger_Ship(int Speed, int LoadCapacity, int Distance, string shipName) : base(Speed, LoadCapacity, Distance)
    {
        ShipName = shipName;
    }
    public override void GetSpeed() => Console.WriteLine($"Скорость {ShipName} - {Speed}");

    public override void GetLoadCapacity() => Console.WriteLine($"Дистанция {ShipName} - {Distance}");

    public override void GetDistanse() => Console.WriteLine($"Грузоподьёмность {ShipName} - {LoadCapacity}");
}
internal class Program
{
    private static void Main(string[] args)
    {
        Passenger_Car yaz = new(60,200,300,"УАЗ");
        Passenger_Aircraft mc = new(180, 18900, 6400, "MC-21-200");
        Passenger_Ship a145 = new(40, 5000, 200, "A-145");

        yaz.GetSpeed();
        mc.GetLoadCapacity();
        a145.GetDistanse();
    }
}