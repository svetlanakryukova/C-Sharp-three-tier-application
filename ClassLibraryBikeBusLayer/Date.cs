﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBikeBusLayer
{
    [Serializable]
    public class Date
    {
        private int month;
        private int day;
        private int year;


        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }

        public int Day
        {
            get { return this.day; }
            set { this.day = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public Date()
        {
            this.month = 00;
            this.day = 00;
            this.year = 0000;
        }

        public Date(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        public override string ToString()
        {
            return this.month + "-" + this.day + "-" + this.year;
        }


    }
}
