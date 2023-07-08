namespace CS_Basic.Module_9_Task_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();
            exception.Data.Add("Дата создания исключения",DateTime.Now);        
            //task 9.1.4
            Exception exception1= new Exception("Сообщение об ошибке");
            exception1.HelpLink = "www.ya.ru";
            Exception exception2 = new ArgumentOutOfRangeException();
            try
            {
                Console.WriteLine("Block try");
                throw exception2;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Block catch");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Block finally");
            }
        }
    }
}