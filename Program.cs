using System.Diagnostics.Metrics;
using System.Threading;

namespace ThreadingProgram
{
    public class Program
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
        public static void ThreadAllProperties(Thread thread)
        {
            ThreadPriority threadPriority = thread.Priority;
            Console.WriteLine("ThreadAllProperties-Priority: {0}", threadPriority);
            Console.WriteLine("ThreadAllProperties-IsAlive: {0}", thread.IsAlive);
            Console.WriteLine("ThreadAllProperties-IsBackground: {0}", thread.IsBackground);
            Console.WriteLine("ThreadAllProperties-Start: {0}", "thread.Start()");
            Console.WriteLine("ThreadAllProperties-Join: {0}", "thread.Join()");
            Console.WriteLine("ThreadAllProperties-Sleep: {0}", "thread.Sleep()");
            Console.WriteLine("ThreadAllProperties-Resume: {0}", "thread.Resume()");
            Console.WriteLine("ThreadAllProperties-Abort: {0}", "thread.Abort()");
            Console.WriteLine("ThreadAllProperties-Suspend: {0}", "thread.Suspend()");
            Console.WriteLine("ThreadAllProperties-Stop: {0}", "thread.Stop()");
            CountUpDownProcess countUpDownProcess = new CountUpDownProcess();
            ThreadStart threadStart = new ThreadStart(countUpDownProcess.CountUp);
            Thread thread1 = new Thread(threadStart);
            thread1.Start();
        }
    }
    public class CountUpDownProcess()
    {
        public void CountUp()
        {
            Thread UpThread = Thread.CurrentThread;
            Console.WriteLine("CountUp Execution");
            Console.WriteLine("CountUp method IsAlive: {0} //default Value", UpThread.IsAlive);
            Console.WriteLine("CountUp method IsBackground: {0} //default Value", UpThread.IsBackground);
        }
        public void CountDown()
        {
            Thread DownThread = Thread.CurrentThread;
            Console.WriteLine("CountDown Execution");
            Console.WriteLine("CountDown method ManagedThreadId: {0} //default Value", DownThread.ManagedThreadId);
            Console.WriteLine("CountDown method ManagedThreadId: {0} //default Value", DownThread.ManagedThreadId);
        }
    }
}
