using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci Series \n 2. Perfect Number \n 3. Prime Number \n 4. Reverse a Number \n 5. Coupon Numbers \n 6. Simulate Stopwatch Program \n 7. Vending Machine \n 8. Day of Week \n 9. Temperature Conversion \n 10. Monthly Payment \n 11. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber number = new PerfectNumber();
                        number.Perfect();
                        break;
                    case 3:
                        PrimeNumber num = new PrimeNumber();
                        num.Prime();
                        break;
                    case 4:
                        ReverseANumber rev = new ReverseANumber();
                        rev.Reverse();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        DayOfWeek day = new DayOfWeek();
                        day.Day();
                        break;
                    case 9:
                        TemperatureConversion temp = new TemperatureConversion();
                        temp.Temp();
                        break;
                    case 10:
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}
