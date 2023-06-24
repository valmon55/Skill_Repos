namespace CS_Basic.Module_6_Autos
{
    class ElectricEngine { }
    class GasEngine { }
    class Battery { }
    public class Differential { } 
    public class Wheel { }
    class Car<T1>
    { 
        T1 Engine;
        Battery battery;
        Differential differential;
        Wheel wheel;

        public virtual void ChangePart<T2>(T2 newPart)
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