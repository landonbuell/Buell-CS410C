using System;
using System.Collections.Generic;
using System.Text;

namespace Program2
{
    class ParseYear
    {
        public int year;
        public bool leap;
        public string calendar_type;

        public ParseYear(int year)
        {
            // Instantiate Year object
            this.year = year;
            if (year > -46 & year < 1753)
            {
                // -46 to 1753 is Julian Calendar
                this.calendar_type = "Julian";
                if (year % 4 == 0)
                {
                    // Julian and divisible by 4? Leap year!
                    this.leap = true;
                }
            }
            else if (year >= 1753 & year < 5000)
            {
                // 1753 to 5000 is Gregorian Calendar
                this.calendar_type = "Gregorian";
                if (year % 4 == 0)
                {
                    if (year % 100 == 0 & year % 400 != 0)
                    {
                        // Divisible by 100? Not a leap year!
                        this.leap = false;
                    }
                    else
                    {
                        // Otherwise, Leap year!
                        this.leap = true;
                    }
                }
            }
            else
            {
                // Year out of range, neither calendar
                this.calendar_type = "None";
                this.leap = false;
            }
        }   

    }
}   
