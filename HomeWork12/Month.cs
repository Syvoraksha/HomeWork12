using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class Month
    {
        private bool leapYear = false;
        public Month(bool _leapYear)
        {
            leapYear = _leapYear;
        }

        public string ReturnDate(int day)
        {
            int monthNumber = ReturnNumberOfMonth(day);
            string monthStr = ReturnMonth(monthNumber);
            int dayOfMonth = ReturnDay(monthNumber, day);
            if (leapYear)
            {
                Console.WriteLine("it is leap year");
            }
            else
            {
                Console.WriteLine("it is not leap year");
            }
            return dayOfMonth + " " + monthStr;
        }

        public int ReturnNumberOfMonth(int day)
        {

            Dictionary<int, int> months = new Dictionary<int, int>();
            months.Add(1, 1);
            months.Add(2, 32);
            months.Add(3, 60);
            months.Add(4, 91);
            months.Add(5, 121);
            months.Add(6, 152);
            months.Add(7, 182);
            months.Add(8, 213);
            months.Add(9, 244);
            months.Add(10, 274);
            months.Add(11, 305);
            months.Add(12, 335);
            months.Add(13, 366);
            //////////////////////////////////////////////////////////////////
            Dictionary<int, int> monthsLY = new Dictionary<int, int>();
            monthsLY.Add(1, 1);
            monthsLY.Add(2, 32);
            monthsLY.Add(3, 61);
            monthsLY.Add(4, 92);
            monthsLY.Add(5, 122);
            monthsLY.Add(6, 153);
            monthsLY.Add(7, 183);
            monthsLY.Add(8, 214);
            monthsLY.Add(9, 245);
            monthsLY.Add(10, 275);
            monthsLY.Add(11, 306);
            monthsLY.Add(12, 336);
            monthsLY.Add(13, 367);

            int month = 0;

            if (!leapYear)
            {
                for (int i = 1; i < months.Count; i++)
                {
                    if (months[i] <= day && months[i + 1] > day)
                    {
                        month = i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 1; i < monthsLY.Count; i++)
                {
                    if (monthsLY[i] <= day && monthsLY[i + 1] > day)
                    {
                        month = i;
                        break;
                    }
                }
            }
            return month;
        }

        public string ReturnMonth(int numberOfMonth)
        {
            Dictionary<int, string> month = new Dictionary<int, string>();
            month.Add(1, "January");
            month.Add(2, "February");
            month.Add(3, "March");
            month.Add(4, "April");
            month.Add(5, "May");
            month.Add(6, "June");
            month.Add(7, "July");
            month.Add(8, "August");
            month.Add(9, "September");
            month.Add(10, "October");
            month.Add(11, "November");
            month.Add(12, "December");

            return month[numberOfMonth];
        }

        public int ReturnDay(int monthNumber, int day)
        {
            Dictionary<int, int> months = new Dictionary<int, int>();

            months.Add(1, 1);
            months.Add(2, 32);
            months.Add(3, 60);
            months.Add(4, 91);
            months.Add(5, 121);
            months.Add(6, 152);
            months.Add(7, 182);
            months.Add(8, 213);
            months.Add(9, 244);
            months.Add(10, 274);
            months.Add(11, 305);
            months.Add(12, 335);
            months.Add(13, 366);
            ////////////////////////////
            Dictionary<int, int> monthsLY = new Dictionary<int, int>();
            monthsLY.Add(1, 1);
            monthsLY.Add(2, 32);
            monthsLY.Add(3, 61);
            monthsLY.Add(4, 92);
            monthsLY.Add(5, 122);
            monthsLY.Add(6, 153);
            monthsLY.Add(7, 183);
            monthsLY.Add(8, 214);
            monthsLY.Add(9, 245);
            monthsLY.Add(10, 275);
            monthsLY.Add(11, 306);
            monthsLY.Add(12, 336);
            monthsLY.Add(13, 367);


            if (!leapYear)
            {
                return day - months[monthNumber] + 1;
            }
            else
            {
                return day - monthsLY[monthNumber] + 1;
            }
        }
    }
}
