using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParalleEx
{
    class ThreadExample3
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// defining a method for Thread
        /// </summary>
        public void thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                log.Info(i);
            }
        }
        static void Main(string[] args)
        {
            try
            {///<summary>
             ///creating a reference for class   
             ///</summary>
                ThreadExample3 t3 = new ThreadExample3();
                Thread t1 = new Thread(new ThreadStart(t3.thread2));
                Thread t2 = new Thread(new ThreadStart(t3.thread2));
                ///starting thread
                t1.Start();
                t2.Start();
            }
            catch (Exception e)
            {
                log.Info(e);
            }
            Console.Read();
        }
    }
}
