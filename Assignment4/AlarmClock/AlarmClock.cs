using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2
{
    class ClockTest
    {
        public void Alarm(object sender, DateTime time)
        {
            Console.WriteLine($"The set time {time} has come!");
        }

        public void Tick(object sender, DateTime time)
        {
            Console.WriteLine($"Now is {time}");
        }
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();
            ClockTest clockTest = new ClockTest();
            DateTime time = DateTime.Now.AddSeconds(5);
            clock.AlarmTime = time;

            clock.OnAlarm += clockTest.Alarm;
            clock.OnTick += clockTest.Tick;

            clock.StartClock();
        }
    }

    class AlarmClock
    {
        private DateTime alarmTime = DateTime.Now;

        public DateTime AlarmTime {
            get => alarmTime;
            set => alarmTime = value;
        }

        public delegate void TickHandler(object sender, DateTime args);
        public delegate void AlarmHandler(object sender, DateTime args);

        public event AlarmHandler OnAlarm;
        public event TickHandler OnTick;

        public void StartClock()
        {
            while (true)
            {
                DateTime presentTime = DateTime.Now;
                OnTick(this, presentTime);
                if (presentTime.ToString() == alarmTime.ToString())
                {
                    OnAlarm(this, alarmTime);
                }
                // every one second excute
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
