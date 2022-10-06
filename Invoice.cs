using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson___2___Classes_and_Objects_
{
    class Invoice
    {
        public string Article { get; set; }
        public int Quantity { get; set; }
        //-------------------------------------------------------------

        int account;
        string customer;
        string provider;
        //-------------------------------------------------------------

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void CostCalculation(bool needNds)
        {
            double cost;
            switch (Article)
            {
                case "laptop":
                    cost = 5400;
                    break;
                case "SD-cadr":
                    cost = 30;
                    break;
                case "USB-hab":
                    cost = 12;
                    break;
                default:
                    Console.WriteLine("Нет ифформации о таком товаре");
                    return;
            }
            if (needNds)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Cуммa оплаты: {0}$", cost * Quantity);
        }
        //-------------------------------------------------------------
    }
}
