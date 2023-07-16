namespace CS_Basic.Module_10_Task_10_2_3
{
    public interface IWorker
    {
        void Build();
    }
    public class Worker : IWorker
    {
        ///
        /// Task 10_2_3 implicite
        ///
        //public void Build() { }

        /// Task 10_2_4
        /// 
        void IWorker.Build() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorker)worker).Build();
        }
    }
}