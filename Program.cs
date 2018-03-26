using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParalleEx
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            try
            {///<summary>
             /// initilizing current thread   
             ///</summary>
                Thread t = Thread.CurrentThread;
                //set name for current thread
                t.Name = "MyThread";
                log.Info(t.Name);
            }
            catch(Exception ex)
            {
                log.Info(ex);
            }
            Console.Read();
        }
    }
}
