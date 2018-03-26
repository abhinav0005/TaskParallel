using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParalleEx
{
    class ThreadMethods
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Thread1()
        {
            log.Info("Thread1 start..");
            for(int i=0; i<=10;i++)
            {
                log.Info(i);
                ///calling Sleep() method
                Thread.Sleep(2000);
            }
        }
        public static void Thread2()
        {
            log.Info("Thread2 start...");
            for (int i = 11; i <= 20; i++)
            {
                log.Info(i);
                ///calling Sleep() method
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            log.Info("Main bagin..");
            ///<summary>
            ///initilization of thread
            /// </summary>
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);
           
            try
            {
                ///running thread
                t1.Start();
                t1.Interrupt();
                log.Info("Thread interrupted");
                t2.Start();

                ///<summary>
                ///calling abort method on thread
                /// </summary>
                t1.Abort();
                t2.Abort();
            }
            catch(ThreadAbortException e)
            {
                log.Info(e);
            }
            log.Info("Main end...");
            Console.Read();
        }
    }
}
