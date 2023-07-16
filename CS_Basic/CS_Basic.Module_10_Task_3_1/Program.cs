namespace CS_Basic.Module_10_Task_3_1
{
    public class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
    public interface IWriter
    {
        void Write();
    }
    public interface IReader
    {
        void Read();
    }
    public interface IMailer
    {
        void SendMessage();
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}