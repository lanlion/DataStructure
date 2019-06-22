using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Data
{
  public   class ReportEntrance
    {
        private static ReportEntrance instance = new ReportEntrance();
        EventWaitHandle backUpWait = new EventWaitHandle(false, EventResetMode.ManualReset);
        public static ReportEntrance GetInstance()
        {
            return instance;
        }
        //线程挂起时间
        private int interval = 2 * 1000;
        //定义线程
        private Thread ReportThread;
        //构造函数，线程开始
        private ReportEntrance()
        {
            try
            {
                this.ReportThread = new Thread(new ThreadStart(ReportThreadProc));
                backUpWait.Set();
                this.ReportThread.Name = "Report Thread";
                this.ReportThread.Start();



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //报表生成方法
        public  void ReportThreadProc()
        {
         
            while (true)
            {
                backUpWait.WaitOne(interval);
                Console.WriteLine("开始执行内容" + DateTime.Now);
                for (int i = 0; i < 10000; i++)
                {
                   if(i%1000==0)
                    {
                         Console.WriteLine(i+ "-State:"+ this.ReportThread.ThreadState);
                       // Console.WriteLine(i);
                    }
                }
                Console.WriteLine("结束执行内容"+DateTime.Now);          
                GC.Collect();
              
            }

        }

       
     
    }
}
