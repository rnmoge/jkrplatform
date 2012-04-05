using System;
using System.Collections.Generic;
using System.Text;

namespace JKR.GUI.LogixConnector
{
    public class clsTicks
    {
        private static long BeginTick;
        private static long StopTick;

        public static void Clear()
        {
            BeginTick = 0L;
            StopTick = 0L;
        }

        public static void Start()
        {
            BeginTick = 0L;
            StopTick = 0L;
            BeginTick =DateTime.Now.Ticks;
        }

        public static long Count()
        {
            return (long)Math.Round((double)(((double)(StopTick - BeginTick)) / 10000.0));
        }

        public static void Stoped()
        {
            StopTick = DateTime.Now.Ticks;
        }

        public static long ReturnCountAfterStop(string Remark,bool Append)
        {
            Stoped();
            long diff = 0L;
            diff = (long)Math.Round((double)(((double)(StopTick - BeginTick)) / 10000.0));
            System.IO.File.WriteAllText(UIProxy.GetCurrentUserFolder() + @"\Traceticks.txt", Remark + ": " + Convert.ToString(diff) + " 毫秒\r\n");
            return diff;
        }

        public static long ReturnCountAfterStop()
        {
            Stoped();
            return (long)Math.Round((double)(((double)(StopTick - BeginTick)) / 10000.0));
        }
    }
}
