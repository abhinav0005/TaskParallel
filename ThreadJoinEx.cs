using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParalleEx
{
    class ThreadJoinEx
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Thread1()
        {
            for(int i =1;i<=10;i++)
            {
                log.Info("t1 "+ i);
                Thread.Sleep(2000);
            }
        }
        public static void Thread2()
        {
            for (int i = 11; i <= 20; i++)
            {
                log.Info("t2 "+i);
                ///calling sleep()
                Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            ///<summary>
            ///creating reference for thread
            /// </summary>
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);
            try
            {
                t1.Start();
                t2.Start();
                ///calling join method on t1
                t1.Join();
            }
            catch(Exception e)
            {
                log.Info(e);
            }
            Console.Read();
        }
    }
}
