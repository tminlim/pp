using System;
using System.Threading;

namespace pex_week09
{
    class Timer
    {
        public static void PrintSec(int sec)
        {
            int i = 0;
            while (i < sec)
            {
                Console.WriteLine(++i);
                Thread.Sleep(500);
            }
        }

        public static void printTimer(int hour, int min, int sec)
        {
            while (true)
            {
            if((sec == 00) && (min == 00)){
                hour--;
                min = 59;
                sec = 59;
            }else if(sec == 00){
                min--;
                sec = 59;
            }else
            {
                sec--;
            }
                Console.WriteLine("{0:00}:{1:00}:{2:00}", hour, min, sec);
                Thread.Sleep(500);
            }
        }

        public static void printStopWatch()
        {
            int i = 0;
            while(true){
                Console.WriteLine(i++);
                Thread.Sleep(100);
            }
        }

        public static void printTime(int hour, int min, int sec)
        {
            while (true)
            {
                if((min == 59) && (sec == 59)){
                    min++;
                    hour++;
                    sec = 0;
                }
                else if (sec == 59)
                {
                    min++;
                    sec = 0;
                }else if(min == 59){
                    hour++;
                    min = 0;
                }
                else
                    sec++;
                Console.WriteLine("{0:00}:{1:00}:{2:00}", hour, min, sec);
                Thread.Sleep(100);
            }
        }



        static void Main(string[] args)
        {     
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            //Timer.PrintSec(10);
            //Console.WriteLine("Bye");

            //Timer.printTimer(h, m, s);
            //Timer.printStopWatch();
            Timer.printTime(h, m, s);
        }
    }
}
