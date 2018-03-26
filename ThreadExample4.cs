using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParalleEx
{
    class ThreadExample4
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// defining Thread1() mathod
        /// </summary>
        public static void Thread1()
        {
            log.Info("I'm thread1");
        }
        /// <summary>
        /// Defining thread2() method
        /// </summary>
        public static void Thread2()
        {
            log.Info("I'm thread2");
        }
        static void Main(string[] args)
        {
            try
            {///<summary>
             ///creating a ref for Thread   
             ///</summary>
                Thread t1 = new Thread(new ThreadStart(Thread1));
                Thread t2 = new Thread(new ThreadStart(Thread2));
                t1.Start();
                t2.Start();
            }
            catch(Exception ex)
            {
                log.Info(ex);
            }
            Console.Read();
        }
    }
}
