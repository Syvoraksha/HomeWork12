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
                   
                    Month month = new Month(menu.IfLeapYear());
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
