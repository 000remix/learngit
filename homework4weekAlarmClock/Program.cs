using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四周_闹钟_事件机制_
{
    public class AlarmclockEventArgs:EventArgs
    {
    }

    public delegate void AlarmclockEventHandler(object sender, AlarmclockEventArgs e);

    public class Time                              //模拟时间增加
    {
        public event AlarmclockEventHandler Alarm;
        public void Clock()
        {
            int H = 0;
            int M = 0;
            SetTime settime = new SetTime { Hour = 5, Minute = 0 };
            if (settime.Hour > 23 || settime.Minute > 59)
            {
                Console.WriteLine("设置时间不符合");
            }
            while (H < 24)
            {
                System.Threading.Thread.Sleep(1000);
                while (M < 60)
                {                  
                    if (H == settime.Hour && M == settime.Minute)
                    {
                        AlarmclockEventArgs args = new AlarmclockEventArgs();
                        Alarm(this, args);
                    }
                    M++;
                }
                H++;
                M = 0;
            }
        }
    }

    class SetTime
    {
        public int Hour { set; get; }
        public int Minute { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var time = new Time();
            time.Alarm += TimeOut;
            time.Clock();
        }
        static void TimeOut(object sender, AlarmclockEventArgs e)
        {
            Console.WriteLine("Time Out");
            Console.ReadLine();
        }
    }
}
