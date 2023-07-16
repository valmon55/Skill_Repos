namespace CS_Basic.Module_10_Task_10_2_2
{
    public interface IWriter
    {
        void Write();
    }
    public class Writer : IWriter
    {
        void IWriter.Write()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();
        }
    }
}