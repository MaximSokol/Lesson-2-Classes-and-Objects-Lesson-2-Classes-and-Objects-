using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson___2___Classes_and_Objects_
{
    class Converter
    {
       int sumOfMoney;
       const double USD = 36.94;
       const double EUR = 38.5;
       const double RUB = 120.3;
       //---------------------------------------------------------------

        public Converter() {}
        //---------------------------------------------------------------

        public void ConvertFromAbroadCash()
        {
            Console.Write("Enter the sum of USD ->\t");
            sumOfMoney = int.Parse(Console.ReadLine());

            Console.Write("Choose the action with the cash ->\t");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine($"USD to UAH:\t{sumOfMoney * USD}");
                    break;
                case 2:
                    Console.WriteLine($"EUR to UAH:\t{sumOfMoney * EUR}");
                    break;
                case 3:
                    Console.WriteLine($"RUB to UAH\t{sumOfMoney * RUB}");
                    break;
                default:
                    Console.WriteLine("The wrong value! Try in again!");
                    break;
            }

        }
        //---------------------------------------------------------------

        public void ConvertFromUAHToAbroadCash()
        {
            Console.Write("Enter the sum of UAH ->\t");
            sumOfMoney = int.Parse(Console.ReadLine());

            Console.Write("Choose the action with the cash ->\t");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine($"UAH to USD:\t{sumOfMoney / USD}");
                    break;
                case 2:
                    Console.WriteLine($"UAH to EUR:\t{sumOfMoney / EUR}");
                    break;
                case 3:
                    Console.WriteLine($"UAH to RUB\t{sumOfMoney / RUB}");
                    break;
                default:
                    Console.WriteLine("The wrong value! Try in again!");
                    break;
            }
        }
        //---------------------------------------------------------------
    }
}
