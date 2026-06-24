using System.Diagnostics.Metrics;
using System.Threading;

namespace ThreadingProgram
{
    public class Examples
    {
        static void Main(string[] args)
        {
            //Get main thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread Start";
            Console.WriteLine(mainThread.Name);
            ThreadAllProperties(mainThread);
            mainThread.Join();
            Console.WriteLine("Main Thread end");
            Console.ReadKey();
        }
        
    }
    
}
