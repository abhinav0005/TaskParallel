using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParalleEx
{
    class NameExample
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Thread1()
        {
            for(int i=1; i<=3;i++)
            {
                Thread t = Thread.CurrentThread;
                log.Info("Thread name is : " +t.Name);
            }
            
        }
    }
    class ThreadNameEx
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            NameExample ne1 = new NameExample();
            Thread t1 = new Thread(ne1.Thread1);
            Thread t2 = new Thread(ne1.Thread1);
            Thread t3 = new Thread(ne1.Thread1);
            try
            {
               
                t1.Name = "First";
                t2.Name = "Second";
                t3.Name = "Third";
                t1.Priority = ThreadPriority.Lowest;
                t2.Priority = ThreadPriority.Normal;
                t3.Priority = ThreadPriority.Highest;
                t1.Start();
                Thread.Sleep(5000);
                t2.Start();
                t3.Start();
            }
            catch(Exception e)
            {
                log.Info(e);
            }
            Console.Read();
        }
    }
}
