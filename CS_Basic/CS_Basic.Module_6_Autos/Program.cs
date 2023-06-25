namespace CS_Basic.Module_6_Autos
{
    class Engine { }
    class CarPart { }
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

        public virtual void ChangePart<TCarPart>(TCarPart newPart) where TCarPart : CarPart
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