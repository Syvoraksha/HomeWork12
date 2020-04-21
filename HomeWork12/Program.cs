using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {

            for (; ; )
            {
                try
                {
                    Menu menu = new Menu();
                    menu.InputDay();
                    int day = 0;
                    day = menu.ReadDay();
                    menu.InputYear();
                    string year;
                    year = menu.ReadYear();
                    Month month = new Month(menu.IfLeapYear(year));
                    Console.WriteLine(month.ReturnDate(day));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

   
        }
    }
}
