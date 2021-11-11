using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        public void Temp()
        {
            Console.WriteLine("Enter Temperature ");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter unit ");
            char un = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The Converted temperature : " + temperatureConversion(temp, un));
        }
        public static int temperatureConversion(int tem, char unit)
        {
            int convert;
            if(unit == 'c' || unit == 'C')
            {
                convert = (tem * 9 / 5) + 32;
            }
            else if(unit == 'f' || unit == 'F')
            {
                convert = (tem - 32) * 5 / 9;
            }
            else
            {
                Console.WriteLine("Enter correct input");
                return 0;
            }
            return convert;
        }
    }
}
