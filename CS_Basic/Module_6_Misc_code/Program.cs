using System.Data.Common;
using System.Runtime.CompilerServices;

namespace test
{
    class BaseClass
    {
        protected string Name;
        public virtual int Counter { get; set; }
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public override int Counter
        {
            get { return Counter; }
            set { if (value >= 0) Counter = value; }
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }
    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Вызван метод класса A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Вызван метод класса C");
        }
    }
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса D");
        }
    }
    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса E");
        }
    }
    class Obj
    {
        public int Value;
        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }

    }
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int idx]
        {
            get
            {
                return array[idx];
            }
            private set
            {
                array[idx] = value;
            }
        }
    }

    public abstract class ComputerPart
    {
        public abstract void Work();
    }
    public class Processor : ComputerPart
    {
        public override void Work()
        {
            return;
        }
    }
    public class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            return;
        }
    }
    public class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            return;
        }
    }
    class Obj1
    {
        string Name;
        string Description;
        static int MaxValue = 2000;
    }
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

    }
    class Obj2
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek = 7;
        public static int MaxValue;
        static Obj2()
        { DaysInWeek = 7; Parent = "System.Object"; MaxValue = 2000; }
    }

    static class IntExtent
    {
        public static int GetNegative(this int i)
        { if (i > 0) { return -i; } else { return i; } }
        public static int GetPositive(this int i)
        { if (i < 0) { return -i; } else { return i; } }
    }

    class Car<T>
    { T Engine; }
    class ElectricEngine
    { }
    class GasEngine
    { }
    class Record<T1, T2>
    { public T1 id; DateTime Date; public T2 Value; }
    internal class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass obj = new DerivedClass("Fed", "test");
            //obj.Display();
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();

            Console.ReadKey();
        }
    }
}