using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdvancedTasks
{
   public static class Program
    {
       public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread process: {0}", i);
                Thread.Sleep(0);
            }
        }



       public static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("This is main Thread!");
                Thread.Sleep(0);
            }
            t.Join();
            Console.ReadLine();
        }
    }
}
