using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson16Task4
{
    class MyDateClass
    {
        int year;
        int month;
        int day;
        double daysDif;

        public MyDateClass(int year, int month, int day)
        {
            if (day > 0 && day < 31 && month > 0 && month < 13 && year > 1900 && year < 2021)
            {
                this.year = year;
                this.month = month;
                this.day = day;
            }
            else
                throw new Exception("Invalid date");
        }

        public MyDateClass(double days)
        {
            this.daysDif = days;
        }

        static public MyDateClass operator -(MyDateClass m1, MyDateClass m2)
        {
            DateTime dateTime1 = new DateTime(m1.year, m1.month, m1.day);
            DateTime dateTime2 = new DateTime(m2.year, m2.month, m2.day);
            double result = (dateTime1 - dateTime2).TotalDays;
            return new MyDateClass(result);
        }

        static public MyDateClass operator +(MyDateClass m1, int plusDays)
        {
            DateTime dateTime1 = new DateTime(m1.year, m1.month, m1.day);
            DateTime dt2 = dateTime1.AddDays(plusDays);
            return new MyDateClass(dt2.Year, dt2.Month, dt2.Day);
        }

        public override string ToString()
        {
            return $"Days: {daysDif}";
        }

        public string ToStringFull()
        {
            return $"Full date {year}/{month}/{day}";
        }
    }
}
