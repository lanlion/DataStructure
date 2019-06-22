using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public class TwoWaySignaling
    {
        //事件等待句柄
        static EventWaitHandle _ready = new AutoResetEvent(false);
        static EventWaitHandle _go = new AutoResetEvent(false);
        static readonly object _locker = new object();
        static string _message;

        public static void run()
        {
            new Thread(Work).Start();
            // 首先等待工作线程就绪
            //(一直的连续的_go.set,会使得work里的_go.waitone来不及处理致使信号被淹没，为了使得信号不被淹没，
            // 每次go发信号前必须用另一个信号_ready在work中发射（通过设置_ready.set())，主线程则只有等待到_ready的发射信号后才能使用go反射信号
            _ready.WaitOne();//当接收到信号后才能往下执行代码                  
            lock (_locker) _message = "ooo";
            Console.WriteLine("输入1继续");
            //if (Console.ReadKey().ToString()=="1")
            //{
            _go.Set();
            //}
            // 通知工作线程执行

            _ready.WaitOne();
            lock (_locker) _message = "ahhh";  // 给工作线程其它信息
            _go.Set();
            _ready.WaitOne();
            lock (_locker) _message = null;    // 发信号通知工作线程退出
            _go.Set();

            Console.ReadKey();
        }

        static void Work()
        {
            while (true)
            {
                //这里ready发射信号，让主线程阻塞，等待主线程接收到ready的发射信号后（_ready.waitone等待会阻塞）
                // go再发射信号，否则go的信号会因为来不及处理而被淹没，之后在主线程的_ready调用_ready_waitone等待阻塞结束后，才让_go调用_go.set()继续发射信号，使得工作线程work更新控制台的输出）
                _ready.Set();                          // 表示我们准备好了
                _go.WaitOne();                         // 等待开始 .set（）是发射信号，.WaitOne()则是等待信号
                lock (_locker)
                {
                    if (_message == null) return;        // 优雅地退出
                    Console.WriteLine(_message);
                }
            }
        }
    }
}
