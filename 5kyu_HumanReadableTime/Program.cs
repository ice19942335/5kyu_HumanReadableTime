using System;

namespace _5kyu_HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            GetReadableTime(0);
            GetReadableTime(5);
            GetReadableTime(60);
            GetReadableTime(86399);
            GetReadableTime(359999);
        }

        public static string GetReadableTime(int seconds)
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }
    }
}
