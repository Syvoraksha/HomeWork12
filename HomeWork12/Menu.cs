using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Menu
    {
        public void InputDay()
        {
            Console.WriteLine("Input day of year");
        }

        public int ReadDay()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            if (day < 1 || day >365) 
            {
                throw new Exception("The number is not the day of the year");
            }

            else
            {
                return day;
            }
          
        }

        public bool IfLeapYear()
        {
            Console.WriteLine("Input year:");
            string year = Console.ReadLine();
            DateTime d = new DateTime(int.Parse(year), 1, 1);
            if (DateTime.IsLeapYear(d.Year))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
