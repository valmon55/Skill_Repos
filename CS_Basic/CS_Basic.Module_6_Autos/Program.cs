namespace CS_Basic.Module_6_Autos
{
    abstract class Engine { }
    abstract class CarPart { }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { } 
    class Battery : CarPart { }
    class Differential : CarPart { } 
    class Wheel :CarPart { }
    class Car<TEngine> where TEngine : Engine
    { 
        TEngine Engine;
        Battery battery;
        Differential differential;
        Wheel wheel;

        public abstract void ChangePart<TCarPart>(TCarPart newPart) where TCarPart : CarPart;

    }
    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TCarPart>(TCarPart newPart)
        { }
    }
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TCarPart>(TCarPart newPart)
        { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}