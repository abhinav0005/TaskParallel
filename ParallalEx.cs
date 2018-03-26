using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParalleEx
{
    class ParallalEx
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            int[] x = new int[] {0, 1, 2, 3, 4, 5};
            try
            {
                ///<summary>
                ///using task parallel
                /// </summary>
                Parallel.For(0, 6, i =>
                {
                    log.Info(i);
                    Thread.Sleep(1000);
                });
            }
            catch(Exception e)
            {
                log.Info(e);
            }
            Console.Read();
        }
    }
}
