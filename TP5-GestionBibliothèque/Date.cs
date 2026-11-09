using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public override string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
        }
        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="date">Date</param>
        public Date(DateTime date)
        {
            this.day = date.Day;
            this.month = date.Month;
            this.year = date.Year;
        }
    }
}
